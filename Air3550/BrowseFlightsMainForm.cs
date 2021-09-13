﻿using Air3550.Database.Context;
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
    //This is the main form for the browse flights tab for the customer
    public partial class BrowseFlightsMainForm : Form
    {
        public bool flightSelected = false;
        public Transaction customerTransaction = new Transaction();
        public Customer customer;
        //parent is set in constructor
        BrowseFlightsTopForm topBrowseFlightsForm;
        //list of paths for the flight (list of list of routes)
        public List<RoutePathing> routePathingsForFlight = new List<RoutePathing>();
        public BrowseFlightsMainForm(BrowseFlightsTopForm browseTopParent)
        {
            InitializeComponent();
            topBrowseFlightsForm = browseTopParent;
            //get customer for later
            using (var db = new FlightContext())
            {
                customer = db.Customers.Single(customer => customer.CustomerID == CustomerSession.CUSTOMER_ID);
            }
        }

        public async Task displayTickets(string origin, string destination, DateTime departureDate, DateTime returnDate, bool oneWay)
        {

            //accesses database to get preference selected in other form and generates the ticket objects
            //Then add them to a list to display
            using (var db = new FlightContext())
            {
                //search database for applicable ID's and run algo
                int departingID = 0;
                int destinationID = 0;
                //find correct cities
                foreach (City city in db.Cities)
                {
                    if (city.CityNameCode == origin)
                    {
                        departingID = city.CityID;
                    }
                    if (city.CityNameCode == destination)
                    {
                        destinationID = city.CityID;
                    }
                }
                //algorithim to get valid paths matching requirements 
                List<RoutePathing> routePaths = await RouteAlgorithim.findRoutePaths(departingID, destinationID);

                //foreach loop to make tickets and display them to the user
                foreach (RoutePathing routePath in routePaths)
                {
                    //make tickets
                    if (!routePath.isGoodLayover())
                    {
                        //it is not a good layover time so continue and dont generate ticket
                        continue;
                    }
                    if (routePath.isFlightFull(departureDate, returnDate))
                    {
                        //pme flight on the path is full, do not generate ticker
                        continue;
                    }
                    TicketForm ticket = new TicketForm(this, routePath);
                    ticket.setUIValues(origin, destination, routePath.getDepartureTimeFormatted(), routePath.getDurationFormatted(), routePath.getArrivalTimeFormatted(), routePath.getStopsFormatted(), routePath.getTotalPriceFormat(), departureDate, returnDate, oneWay);
                    ticket.TopLevel = false;
                    ticket.Visible = true;
                    flowLayoutPanel1.Controls.Add(ticket);
                }
            }
        }

        //clears the panel
        public void clearFlowLayoutPanel()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        //clears the routepaths
        public void clearroutePathsForFlight()
        {
            routePathingsForFlight.Clear();
        }

        //checks if this is a round trip
        public bool isRoundTrip()
        {
            if (topBrowseFlightsForm.roundTripRadioButton.Checked)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        //autogenerated, do nothing
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}