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
    //This is the main flight manager form 
    public partial class FlightManagerForm : Form
    {
        //parent is set in constructor
        LoginForm loginFormParent;
        public bool logoutClicked = false;
        public FlightManagerForm(LoginForm loginForm)
        {
            InitializeComponent();
            loginFormParent = loginForm;
        }

        //exit aplication when exit button is clicked
        private void accountantExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //when closing, log out and close app correctly
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (!logoutClicked)
            {
                Application.Exit();
            }
        }

        //add relevant flights using dates to panel to display when browse button is clicked
        private async void browseFlightsButton_Click(object sender, EventArgs e)
        {

            using (var db = new FlightContext())
            {
                //Clear panel before populating tickets
                flightManagerFlowLayoutPanel.Controls.Clear();
                //get all flights and its tickets where it is not canceled and get the transaction and customer tied to that ticket
                //Also the query checks to see if the fligtht is within the correct dates
                var flights = await db.Flights
                    .Include(flight => flight.Tickets.Where(ticket => !ticket.IsCanceled)).ThenInclude(ticket => ticket.Transaction).ThenInclude(transaction => transaction.TransactionCustomer)
                    .Include(flight => flight.FlightRoute).ThenInclude(route => route.RouteOriginCity)
                    .Include(flight => flight.FlightRoute).ThenInclude(route => route.RouteDestinationCity)
                    .Include(flight => flight.FlightRoute).ThenInclude(route => route.FlightAircraft)
                    .Where(flight => flight.FlightDate.Date >= startDateTimePicker.Value.Date && flight.FlightDate.Date <= endingDateTimePicker.Value.Date)
                    .ToListAsync();

                // loop through all flights
                foreach (Flight flight in flights)
                {
                    //set values for the UI
                    string capacitySold = flight.Tickets.Count().ToString();
                    string origin = flight.FlightRoute.RouteOriginCity.CityNameCode;
                    string destination = flight.FlightRoute.RouteDestinationCity.CityNameCode;
                    string dateOfFlight = flight.FlightDate.ToString("d");

                    //get list of customers
                    List<Customer> customerList = new List<Customer>();
                    //Get customer tied to each noncanceled ticket in the flight
                    foreach (Ticket ticket in flight.Tickets)
                    {
                        customerList.Add(ticket.Transaction.TransactionCustomer);
                    }    
                    //Make ticket and add to panel, setting valid UI labels
                    FlightManagerTicketForm ticket1 = new FlightManagerTicketForm(this);
                    ticket1.setUIValues(dateOfFlight, origin, destination, capacitySold, customerList, "Flight Number:" + flight.FlightID);
                    ticket1.TopLevel = false;
                    ticket1.Visible = true;
                    flightManagerFlowLayoutPanel.Controls.Add(ticket1);

                };

            }

            
        }

        //Clear button to clear panel
        private void button1_Click(object sender, EventArgs e)
        {
            flightManagerFlowLayoutPanel.Controls.Clear();
        }

        //logout button click, user will logout correctly
        private void flightManagerLogOutButton_Click(object sender, EventArgs e)
        {
            //log out of session
            logoutClicked = true;
            this.Close();
            CustomerSession.logout();
            loginFormParent.Visible = true;
        }
    }
}
