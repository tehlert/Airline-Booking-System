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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air3550
{
    //This class contains all the logic for the accountant form
    public partial class AccountantForm : Form
    {
        //parent assigned when initialized, for logout button
        LoginForm loginFormParent;
        //flag to confirm the logout was clicked on close
        public bool logoutClicked = false;
        //Constructor for form
        public AccountantForm(LoginForm loginForm)
        {
            InitializeComponent();
            loginFormParent = loginForm;
        }

        //When hitting the exit button, exit the application
        private void accountantExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //When hitting the 'X' either exit application or go back to login form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (!logoutClicked)
            {
                Application.Exit();
            }
        }

        //This method clears the panel and populates it with relevant tickets and statistics
        private async void generateReportButton_Click(object sender, EventArgs e)
        {

            //clear panel
            accountantReportFlowLayoutPanel1.Controls.Clear();
            await DisplayReportTickets(startDateTimePicker.Value, endingDateTimePicker.Value);
        }

        //This task displays all the tickets and values retrieved from the db
        private async Task DisplayReportTickets(DateTime startReportDate, DateTime endReportDate)
        {
            //get a new context of the db
            using (var db = new FlightContext())
            {
                decimal totalPrice = 0;
                //this query gets all the flights where the tickets in it are not canceled, and it is within the range selected by the accountant
                var flights = await db.Flights
                    .Include(flight => flight.Tickets.Where(ticket => !ticket.IsCanceled))
                    .Include(flight => flight.FlightRoute).ThenInclude(route => route.RouteOriginCity)
                    .Include(flight => flight.FlightRoute).ThenInclude(route => route.RouteDestinationCity)
                    .Include(flight => flight.FlightRoute).ThenInclude(route => route.FlightAircraft)
                    .Where(flight => flight.FlightDate.Date >= startDateTimePicker.Value.Date && flight.FlightDate.Date <= endingDateTimePicker.Value.Date)
                    .ToListAsync();
                flightCountNumberLabel.Text = flights.Count.ToString();
                // loop through all flights and get tickets
                foreach (Flight flight in flights)
                {
                    //update totalprice
                    totalPrice += (flight.FlightRoute.getPrice() * flight.Tickets.Count);

                    //Set strings to set UI of main form and tickets
                    string maxCapacity = "Max Capacity:" + flight.FlightRoute.FlightAircraft.AircraftCapacity;
                    string ticketsSold = "Tickets Sold:" + flight.Tickets.Count;
                    string totalIncome = "Total Income:$" + (flight.FlightRoute.getPrice() * flight.Tickets.Count);
                    string flightDate = flight.FlightDate.ToString("d");
                    string flightNumber = flight.FlightID.ToString();
                    string percentFull = Math.Round((((double)flight.Tickets.Count/ (double)flight.FlightRoute.FlightAircraft.AircraftCapacity)*100), 2) + "% full";

                    //Make new ticket form, set values, and add to panel
                    AccountantTicketForm ticket = new AccountantTicketForm();
                    ticket.setUIValues(flightNumber, flightDate, totalIncome, maxCapacity, ticketsSold, percentFull);
                    ticket.TopLevel = false;
                    ticket.Visible = true;
                    accountantReportFlowLayoutPanel1.Controls.Add(ticket);
                }
                companyNumberIncomeLabel.Text = "$" + totalPrice;

            }
        }

        //auto generated, do nothing
        private void fightCountNumberLabel_Click(object sender, EventArgs e)
        {

        }

        //close form and redirect back to parent login form
        private void accountantLogOutButton_Click(object sender, EventArgs e)
        {
            logoutClicked = true;
            this.Close();
            //log out of session
            CustomerSession.logout();
            loginFormParent.Visible = true;
        }
    }
}
