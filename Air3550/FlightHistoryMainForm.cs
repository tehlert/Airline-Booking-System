/*
 Air 3550 Project Team 7

This program is a basic flight reservation system for a fake airline company
It allows customers to book, manage, cancel, and browse flights within a database.
It also allows employee accounts to update and manage flights and view business statistics.

Written by: Harrison Kania, Tyler Ehlert, Daniel Wellons
For EECS3550-001 Software Engineering, Instructor: Dr. Thomas 
 */
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
    //This is the main form for when the flight history button is clicked from the customer form
    public partial class FlightHistoryMainForm : Form
    {
        //parent is set in constructor
        public flightHistoryTopForm topHistoryForm;
        public FlightHistoryMainForm(flightHistoryTopForm historyTopParent)
        {
            InitializeComponent();
            topHistoryForm = historyTopParent;
            //loop through transactions and add them to the panels
            using (var db = new FlightContext())
            { 
                //getting each transaction and it tickets tied to the customer logged in 
                foreach(Transaction transaction in db.Transactions.Include(transaction => transaction.Tickets).Where(tranID => tranID.TransactionCustomerID == CustomerSession.CUSTOMER_ID))
                {

                    //generate transaction form, making variables for ui values
                    bool isRoundTrip = false;
                    string firstDepartAirportCode = "";
                    string firstArrivalAirportCode = "";
                    string secondDepartAirportCode = "";
                    string secondArrivalAirportCode = "";
                    string firstFlightDateString = "";
                    string secondFlightDateString = "";
                    string firstDepartTime = "";
                    string firstArrivalTime = "";
                    string secondDepartTime = "";
                    string secondArrivalTime = "";
                    int firstFlightNumber = 0;
                    int secondFlightNumber = 0;
                    string paymentMethod = "";
                    string cost = "";
                    //loop through all tickets and get their flights, check to see if a date is different, if it is it is a round trip
                    for (int i = 1; i < transaction.Tickets.Count; i++)
                    {
                        //get correct models from DB
                        Ticket previousTicket = transaction.Tickets[i - 1];
                        Ticket currentTicket = transaction.Tickets[i];
                        Flight flightForPreviousTicket = db.Flights.Single(flight => flight.FlightID == previousTicket.FlightID);
                        Route routeAssignedToPreviousTicket = db.Routes.Include(route => route.RouteOriginCity).Include(route => route.RouteDestinationCity).Single(route => route.RouteID == flightForPreviousTicket.FlightRouteID);
                        Flight flightForTicket = db.Flights.Single(flight => flight.FlightID == currentTicket.FlightID);
                        Route routeAssignedToTicket = db.Routes.Include(route => route.RouteOriginCity).Include(route => route.RouteDestinationCity).Single(route => route.RouteID == flightForTicket.FlightRouteID);

                        //compare dates
                        if (DateTime.Compare(flightForPreviousTicket.FlightDate, flightForTicket.FlightDate) != 0)
                        {
                            //know it is round trip, so set applicable values
                            isRoundTrip = true;
                            secondFlightNumber = flightForTicket.FlightID;
                            firstArrivalAirportCode = routeAssignedToPreviousTicket.RouteDestinationCity.CityNameCode;
                            secondDepartAirportCode = routeAssignedToTicket.RouteOriginCity.CityNameCode;
                            secondFlightDateString = flightForTicket.FlightDate.ToString("d");
                            secondDepartTime = routeAssignedToTicket.FlightDepartureTime.ToString(@"hh\:mm");
                            firstArrivalTime = routeAssignedToPreviousTicket.getArrivalTime().ToString(@"hh\:mm");
                            break;
                        }
                    }

                    // accessing DB to set strings to get first trip departure date, origin code, destination code, departure and arrival times
                    Flight firstFlightForTransaction = db.Flights.Single(flight => flight.FlightID == transaction.Tickets.First().FlightID);
                    firstFlightNumber = firstFlightForTransaction.FlightID;
                    firstFlightDateString = firstFlightForTransaction.FlightDate.ToString("d");
                    Flight  lastFlightForTransaction = db.Flights.Single(flight => flight.FlightID == transaction.Tickets.First().FlightID);
                    Route routeAssignedToFirstFlight = db.Routes.Include(route => route.RouteOriginCity).Include(route => route.RouteDestinationCity).Single(route => route.RouteID == firstFlightForTransaction.FlightRouteID);
                    Route routeAssignedToLastFlight = db.Routes.Include(route => route.RouteOriginCity).Include(route => route.RouteDestinationCity).Single(route => route.RouteID == lastFlightForTransaction.FlightRouteID);

                    //getting exact departure time by using flight date and route departing time values
                    DateTime exactDepartureTime = new DateTime(firstFlightForTransaction.FlightDate.Year, firstFlightForTransaction.FlightDate.Month, firstFlightForTransaction.FlightDate.Day, routeAssignedToFirstFlight.FlightDepartureTime.Hours, routeAssignedToFirstFlight.FlightDepartureTime.Minutes, routeAssignedToFirstFlight.FlightDepartureTime.Seconds);

                    //if round trip, set applicable values
                    if (isRoundTrip)
                    {
                        firstDepartAirportCode = routeAssignedToFirstFlight.RouteOriginCity.CityNameCode;
                        secondArrivalAirportCode = routeAssignedToLastFlight.RouteDestinationCity.CityNameCode;
                        secondArrivalTime = routeAssignedToLastFlight.getArrivalTime().ToString(@"hh\:mm");
                        firstDepartTime = routeAssignedToFirstFlight.FlightDepartureTime.ToString(@"hh\:mm");

                    }
                    else
                    {
                        firstDepartAirportCode = routeAssignedToFirstFlight.RouteOriginCity.CityNameCode;
                        firstArrivalAirportCode = routeAssignedToLastFlight.RouteDestinationCity.CityNameCode;
                        firstDepartTime = routeAssignedToFirstFlight.FlightDepartureTime.ToString(@"hh\:mm");
                        firstArrivalTime = routeAssignedToLastFlight.getArrivalTime().ToString(@"hh\:mm");
                    }

                    paymentMethod = transaction.TransactionBillingType;
                    cost = transaction.TransactionTotalPrice.ToString();

                    //see if it has happened already
                    bool isCurrent = !(DateTime.Compare(exactDepartureTime, DateTime.Now) < 0);

                    //make ticket and set its UI values
                    HistoryTicketForm ticket = new HistoryTicketForm(isCurrent, transaction.isCanceled, transaction, this, exactDepartureTime);
                    ticket.setUIValues(firstDepartAirportCode, firstArrivalAirportCode, secondDepartAirportCode, 
                        secondArrivalAirportCode, firstFlightDateString, secondFlightDateString, firstDepartTime, firstArrivalTime, secondDepartTime, 
                        secondArrivalTime, cost, paymentMethod, isRoundTrip, firstFlightNumber, secondFlightNumber);
                    ticket.TopLevel = false;
                    ticket.Visible = true;

                    //check to add ticket to the correct panel
                    if (isCurrent && !transaction.isCanceled)
                    {
                        currentFlowLayoutPanel.Controls.Add(ticket);
                    }
                    else 
                    {
                        pastFlowLayoutPanel.Controls.Add(ticket);
                    }
                }
            }

        }

        //do nothing here, aurogenerated
        private void pastFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
