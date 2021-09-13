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
    //this is the ticket form used in the browse flights panel
    public partial class TicketForm : Form
    {

        //variables for manipulation
        BrowseFlightsMainForm browseFlightsMainParent;
        RoutePathing routeForTicket;
        DateTime returnDateForTicket;
        DateTime ticketDate;
        bool isOneWayFlight = false;

        public TicketForm(BrowseFlightsMainForm browseMainParent, RoutePathing routePath)
        {
            InitializeComponent();
            browseFlightsMainParent = browseMainParent;
            routeForTicket = routePath;
        }

        //bring up new form displaying this flights data
        private async void bookFlightButton_Click(object sender, EventArgs e)
        {
            //if it is not one way and a flight has not been selected, add routepath and display next set of tickets, else open booking form with correct parameters
            if (browseFlightsMainParent.flightSelected == false  && !isOneWayFlight)
            {
                browseFlightsMainParent.routePathingsForFlight.Add(routeForTicket);
                browseFlightsMainParent.flowLayoutPanel1.Controls.Clear();

                await browseFlightsMainParent.displayTickets(arrivalAirportLabel.Text, departAirportLabel.Text, ticketDate, returnDateForTicket, false);
                //Set that flight is selected
                browseFlightsMainParent.flightSelected = true;
            }
            else
            {
                browseFlightsMainParent.routePathingsForFlight.Add(routeForTicket);
                //Pop up confirm flight or flights form
                BookFlight bookFlightForm = new BookFlight(browseFlightsMainParent, isOneWayFlight, ticketDate, returnDateForTicket);
                bookFlightForm.ShowDialog();
                //reset values
                browseFlightsMainParent.flightSelected = false;
            }
        }
        public void setUIValues(string origin, string destination, string departTime, string travelTime, string arrivalTime, string legs, string price, DateTime departureDate, DateTime returnDate, bool isOneWay)
        {
            //set labels for UI for ticket
            departAirportLabel.Text = origin;
            arrivalAirportLabel.Text = destination;
            departLabel.Text = departTime;
            flightTimeLabel.Text = travelTime;
            arrivalLabel.Text = arrivalTime;
            legsLabel.Text = legs;
            priceLabel.Text = price;

            isOneWayFlight = isOneWay;
            ticketDate = departureDate;
            returnDateForTicket = returnDate;
        }
    }
}
