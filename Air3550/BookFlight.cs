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
    //This class is the form for when a ticket's book flight button is clicked
    public partial class BookFlight : Form
    {
        //parent is set in constructor
        BrowseFlightsMainForm browseFlightsMainParent;
        DateTime departingDate;
        DateTime returningDate;
        //override so application can exit properly
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            browseFlightsMainParent.clearFlowLayoutPanel();
            browseFlightsMainParent.clearroutePathsForFlight();
        }
        //The constructor sets the UI values based on if it was one way or not, it gets these values from the DB
        public BookFlight(BrowseFlightsMainForm browseMainParent, bool isOneWay, DateTime departureDate, DateTime returnDate)
        {
            InitializeComponent();
            browseFlightsMainParent = browseMainParent;
            departingDate = departureDate;
            returningDate = returnDate;
            //if round trip, set appropriate labels and make them visible, else just set labels for one
            if (!isOneWay)
            {
                departSecondAirportLabel.Visible = true;
                arriveAirportLabel.Visible = true;
                pictureBox2.Visible = true;
                legsSecondLabel.Visible = true;
                secondPriceLabel.Visible = true;

                using (var db = new FlightContext())
                {
                    //get route path from parent and set values from the database
                    RoutePathing routePath1 = browseFlightsMainParent.routePathingsForFlight[0];
                    Customer customerSelected = db.Customers.Single(customer => customer.CustomerID == browseFlightsMainParent.customer.CustomerID);
                    Route routeSelectedFirst = db.Routes.Single(route => route.RouteID == routePath1.Routes.First().RouteID);
                    Route routeSelectedLast = db.Routes.Single(route => route.RouteID == routePath1.Routes.Last().RouteID);
                    City originCitySelected = db.Cities.Single(city => city.CityID == routeSelectedFirst.RouteOriginCityID);
                    City arrivalCitySelected = db.Cities.Single(city => city.CityID == routeSelectedLast.RouteDestinationCityID);
                    legsFirstLabel.Text = routePath1.getStopsFormatted();
                    firstPriceLabel.Text = routePath1.getTotalPriceFormat();
                    departFirstAirportLabel.Text = originCitySelected.CityNameCode;
                    arriveFirstAirportLabel.Text = arrivalCitySelected.CityNameCode;
                    pointsValueLabel.Text = customerSelected.CurrentPoints.ToString();

                    RoutePathing routePath2 = browseFlightsMainParent.routePathingsForFlight[1];
                    Route route2SelectedFirst = db.Routes.Single(route => route.RouteID == routePath2.Routes.First().RouteID);
                    Route route2SelectedLast = db.Routes.Single(route => route.RouteID == routePath2.Routes.Last().RouteID);
                    City originCitySelected2 = db.Cities.Single(city => city.CityID == route2SelectedFirst.RouteOriginCityID);
                    City arrivalCitySelected2 = db.Cities.Single(city => city.CityID == route2SelectedLast.RouteDestinationCityID);

                    legsSecondLabel.Text = routePath2.getStopsFormatted();
                    secondPriceLabel.Text = routePath2.getTotalPriceFormat();
                    departSecondAirportLabel.Text = originCitySelected2.CityNameCode;
                    arriveAirportLabel.Text = arrivalCitySelected2.CityNameCode;
                    decimal.TryParse(routePath1.getTotalPrice(), out decimal path1Price);
                    decimal.TryParse(routePath2.getTotalPrice(), out decimal path2Price);

                    totalPriceLabel.Text = (path1Price + path2Price).ToString();
                }
            }
            else
            {
                //not round trip, do the same as above but only one way flight
                using (var db = new FlightContext())
                {
                    RoutePathing routePath1 = browseFlightsMainParent.routePathingsForFlight[0];
                    Customer customerSelected = db.Customers.Single(customer => customer.CustomerID == browseFlightsMainParent.customer.CustomerID);
                    Route routeSelectedFirst = db.Routes.Single(route => route.RouteID == routePath1.Routes.First().RouteID);
                    Route routeSelectedLast = db.Routes.Single(route => route.RouteID == routePath1.Routes.Last().RouteID);
                    City originCitySelected = db.Cities.Single(city => city.CityID == routeSelectedFirst.RouteOriginCityID);
                    City arrivalCitySelected = db.Cities.Single(city => city.CityID == routeSelectedLast.RouteDestinationCityID);
                    legsFirstLabel.Text = routePath1.getStopsFormatted();
                    firstPriceLabel.Text = routePath1.getTotalPriceFormat();
                    departFirstAirportLabel.Text = originCitySelected.CityNameCode;
                    arriveFirstAirportLabel.Text = arrivalCitySelected.CityNameCode;
                    pointsValueLabel.Text = customerSelected.CurrentPoints.ToString();
                    totalPriceLabel.Text = routePath1.getTotalPrice();
                }

            }
        }      

        //Add transactions to database and set appropriate values for transaction, this is on the final book flight button
        private async void bookFlightsFinalButton_Click(object sender, EventArgs e)
        {
            //add transactions to db so they are associated with customer
            Transaction transactionForTicket = new Transaction
            {
                TransactionBookingDate = DateTime.Now,
                TransactionCustomerID = browseFlightsMainParent.customer.CustomerID,
                TransactionType = browseFlightsMainParent.customer.CustomerCreditCardNumber,
                TransactionTotalPrice = 123,
                TransactionBillingType = "billing",
                PointsClaimed = false,
                isCanceled = false
            };
            using (var db = new FlightContext())
            {
                decimal.TryParse(totalPriceLabel.Text, out decimal flightTotalPrice);
                //book flight and subtract points
                if (usePointsCheckBox.Checked == true)
                {
                    decimal.TryParse(pointsValueLabel.Text, out decimal customerStartingPoints);
                    Customer customerSelected = db.Customers.Single(customer => customer.CustomerID == browseFlightsMainParent.customer.CustomerID);
                    customerSelected.CurrentPoints = (int)(customerStartingPoints - flightTotalPrice * 100);
                    customerSelected.UsedPoints += (int)flightTotalPrice * 100;
                    transactionForTicket.TransactionBillingType = "points";
                    transactionForTicket.TransactionType = "points";
                    transactionForTicket.TransactionTotalPrice = flightTotalPrice * 100;
                }
                else
                {
                    transactionForTicket.TransactionTotalPrice = flightTotalPrice;
                }

                //iterator to check if round trip, will either be 1 or 2
                int i = 0;
                //loop through route pathings and set flights and tickets based of them
                foreach (RoutePathing routePathing in browseFlightsMainParent.routePathingsForFlight)
                {
                    i++;
                    foreach (Route route in routePathing.Routes)
                    {
                        //see if there is a flight already in the db, if not make a new flight
                        if (i == 1)
                        {
                            // first route path, set approptiate values
                            Flight flightForTicket = await db.Flights.Include(flight => flight.FlightRoute).SingleOrDefaultAsync(flight => flight.FlightRouteID == route.RouteID && flight.FlightDate == departingDate);
                            if (flightForTicket == null)
                            {
                                //create a new flight
                                flightForTicket = new Flight
                                {
                                    FlightDate = departingDate,
                                    FlightRouteID = route.RouteID
                                };
                            }
                            //now create ticket and add to transaction
                            Ticket ticketForFlight = new Ticket
                            {
                                Flight = flightForTicket,
                                IsCanceled = false
                            };
                            transactionForTicket.Tickets.Add(ticketForFlight);
                        }
                        else if (i == 2)
                        {
                            // second route path, set approptiate values
                            Flight flightForTicket = await db.Flights.Include(flight => flight.FlightRoute).SingleOrDefaultAsync(flight => flight.FlightRouteID == route.RouteID && flight.FlightDate == returningDate);
                            if (flightForTicket == null)
                            {
                                //create a new flight
                                flightForTicket = new Flight
                                {
                                    FlightDate = returningDate,
                                    FlightRouteID = route.RouteID
                                };
                            }
                            //now create ticket and add to transaction
                            Ticket ticketForFlight = new Ticket
                            {
                                Flight = flightForTicket,
                                IsCanceled = false
                            };
                            transactionForTicket.Tickets.Add(ticketForFlight);
                        }       
                    }
                }
                //save changes to db
                await db.AddAsync(transactionForTicket);
                await db.SaveChangesAsync();
                //Transaction made
                MessageBox.Show("Flight Booked Successfully!");
                browseFlightsMainParent.clearFlowLayoutPanel();
                //clear routepaths
                browseFlightsMainParent.clearroutePathsForFlight();
                this.Close();
            }
        }

        //If cancel clicked, reset main view panel to clear and reset transaction list
        private void cancelTransactionButton_Click(object sender, EventArgs e)
        {
            browseFlightsMainParent.clearFlowLayoutPanel();
            //cancel routepaths
            browseFlightsMainParent.clearroutePathsForFlight();
            this.Close();
        }

        //check if customer can use points, if not then display pop-up and uncheck
        private void usePointsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            decimal.TryParse(pointsValueLabel.Text, out decimal value);
            decimal.TryParse(totalPriceLabel.Text, out decimal totalValue);
            if (value / 100 < totalValue && usePointsCheckBox.Checked == true)
            {
                MessageBox.Show("Not enough points in account to pay total");
                usePointsCheckBox.Checked = false;
            }
        }
    }
}
