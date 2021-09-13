using Air3550.Database.Context;
using Air3550.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Air3550
{
    //this is the ticket form for flight history
    public partial class HistoryTicketForm : Form
    {
        //variables for manipulation
        public bool isRoundTrip = false;
        public int flightNumber = 0;
        public int returnFlightNumber = 0;

        public DateTime ticketDepartureDate;
        public DateTime ticketDepartureDateDayBefore;
        public TimeSpan dayDifference = new TimeSpan(23, 59, 59);

        public bool canceled = false;
        public Transaction ticketTransaction;
        //parent set in constructor
        public FlightHistoryMainForm mainFormParent;
        //constructor makes form and checks to see if the ticket is canceld
        public HistoryTicketForm(bool current, bool isCanceled, Transaction transactionForTicket, FlightHistoryMainForm parent, DateTime ticketDepartingDate)
        {
            InitializeComponent();
            mainFormParent = parent;
            ticketTransaction = transactionForTicket;
            canceled = isCanceled;

            //set correct dates for manipulation(1 hour and 24 hours before for canceling and printing pass)
            ticketDepartureDate = ticketDepartingDate.AddHours(-1);
            ticketDepartureDateDayBefore = ticketDepartingDate.AddHours(-24);
            if(!current || isCanceled)
            {
                //hide buttons
                cancelFlightButton.Visible = false;
                printPassButton.Visible = false;
                takenLabel.Visible = true;
                takenYesNoLabel.Visible = true;
            }
        }

        //do nothing, autogen
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //This function sets the values for the labels in the ticket
        public void setUIValues(string firstAirportCode, string firstArrivalCode, string secondAirportCode, string secondArrivalCode,
            string firstDate, string secondDate, string firstDepart, string firstArrival, string secondDepart, string secondArrival,
            string totalCost, string paymentMethod, bool roundTrip, int firstNumber, int secondNumber)
        {
            isRoundTrip = roundTrip;
            //set labels for UI
            if (roundTrip)
            {
                //make labels visible for trip
                returnTripDateLabel.Visible = true;
                roundTripOriginLabel.Visible = true;
                roundTripDestinationLabel.Visible = true;
                roundTripArrivalTimeLabel.Visible = true;
                roundTripDepartingTimeLabel.Visible = true;
            }
            //set values of labels
            if (canceled)
            {
                canceledYesNoLabel.Text = "Yes";
                takenYesNoLabel.Text = "No";
            }
            else
            {
                canceledYesNoLabel.Text = "No";
                takenYesNoLabel.Text = "Yes";
            }
            flightNumber = firstNumber;
            returnFlightNumber = secondNumber;
            departAirportLabel.Text = firstAirportCode;
            arrivalAirportLabel.Text = firstArrivalCode;
            roundTripOriginLabel.Text = secondAirportCode;
            roundTripDestinationLabel.Text = secondArrivalCode;
            departDateTimeLabel.Text = firstDate;
            returnTripDateLabel.Text = secondDate;
            departLabel.Text = firstDepart;
            arrivalLabel.Text = firstArrival;
            roundTripDepartingTimeLabel.Text = secondDepart;
            roundTripArrivalTimeLabel.Text = secondArrival;
            totalCostLabel.Text = totalCost;
            paymentTypeLabel.Text = paymentMethod;
        }

        // "print" boarding pass, pop-up form is generated with correct info
        private void printPassButton_Click(object sender, EventArgs e)
        {
            //check if it is 24 hours before the flight
            if (DateTime.Compare(DateTime.Now, ticketDepartureDateDayBefore) > 0)
            {
                //pop up form with boarding pass info
                using (var db = new FlightContext())
                {
                    //make customer and set ui values for boarding pass
                    Customer customer = db.Customers.Single(customer => customer.CustomerID == CustomerSession.CUSTOMER_ID);
                    BoardingPassPopUpForm boardingPass = new BoardingPassPopUpForm();
                    boardingPass.setUIValues("FlightNumber: " + flightNumber, departDateTimeLabel.Text, departAirportLabel.Text, arrivalAirportLabel.Text,
                        departLabel.Text, arrivalLabel.Text, "FlightNumber: " + returnFlightNumber, returnTripDateLabel.Text, roundTripOriginLabel.Text,
                        roundTripDestinationLabel.Text, roundTripDepartingTimeLabel.Text, roundTripArrivalTimeLabel.Text, customer.CustomerFirstName, 
                        customer.CustomerLastName, customer.CustomerUsername, isRoundTrip);
                    boardingPass.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("You can only print a boarding pass 24 hours prior to the flight");
            }

        }

        //cancel button click even
        private async void cancelFlightButton_Click(object sender, EventArgs e)
        {

            //if it is an hour before departure time, it cannot be canceled
            if (DateTime.Compare(DateTime.Now, ticketDepartureDate) > 0)
            {
                MessageBox.Show("You cannot cancel an hour before departure time");
            }
            else
            {
                //else, credit points and cancel transaction
                using (var db = new FlightContext())
                {
                    Customer customer = db.Customers.Single(customer => customer.CustomerID == CustomerSession.CUSTOMER_ID);
                    Transaction transactionForTicket = await db.Transactions.Include(ticket => ticket.Tickets).SingleAsync(transaction => transaction.TransactionID == ticketTransaction.TransactionID);
                    //cancel transaction
                    if (transactionForTicket.TransactionBillingType == "points")
                    {
                        //refund points
                        customer.CurrentPoints += (int)transactionForTicket.TransactionTotalPrice;
                    }
                    else
                    {
                        //refund credit AS points ( 10 points per dollar)
                        customer.CurrentPoints += ((int)transactionForTicket.TransactionTotalPrice * 10);
                    }
                    transactionForTicket.isCanceled = true;
                    //cancel all tickets
                    foreach (Ticket ticket in transactionForTicket.Tickets)
                    {
                        ticket.IsCanceled = true;
                    }
                    await db.SaveChangesAsync();
                }
                mainFormParent.topHistoryForm.customerForm.flightHistoryClicked = false;
                mainFormParent.topHistoryForm.customerForm.flightHistoryButton_Click(null, null);
            }
        }
    }
}
