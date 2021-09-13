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
    //this is the main form for the load engineer
    public partial class LoadEngineerForm : Form
    { 
        //make route object and relevant variables
        public Route newRoute = new Route();
        public LoadEngineerForm ticket;
        LoginForm loginFormParent;
        public bool logoutClicked = false;

        //basic comboitem for comboboxes
        public class ComboItem
        {
            public int ID { get; set; }
            public string Airport { get; set; }
        }
        //constructor, gets values for comboboxes and makes form
        public LoadEngineerForm(LoginForm loginForm)
        {
            loginFormParent = loginForm;
            InitializeComponent();
            List<ComboItem> comboItemsOrigin = new List<ComboItem>();
            List<ComboItem> comboItemsDestination = new List<ComboItem>();
            //populate origin combobox on startup
            using (var db = new FlightContext())
            {
                //Populate cities in combobox from database
                foreach (City city in db.Cities)
                {
                    comboItemsOrigin.Add(new ComboItem { ID = city.CityID, Airport = city.CityNameCode });
                    comboItemsDestination.Add(new ComboItem { ID = city.CityID, Airport = city.CityNameCode });
                }

                originComboBox.DataSource = comboItemsOrigin;
                destinationComboBox.DataSource = comboItemsDestination;

                originComboBox.DisplayMember = "Airport";
                originComboBox.ValueMember = "ID";
                originComboBox.MaxDropDownItems = 8;

                destinationComboBox.DisplayMember = "Airport";
                destinationComboBox.ValueMember = "ID";
                destinationComboBox.MaxDropDownItems = 8;
            }
        }

        //when closing, logout or close app correctly
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (!logoutClicked)
            {
                Application.Exit();
            }
        }

        //exit app
        private void accountantExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Direct engineer to a form where he can add a new flight to the database
        private void addNewFlightButton_Click(object sender, EventArgs e)
        {
            using (var db = new FlightContext())
            {
                //search database for applicable ID's and run algo
                int departingID = 0;
                int destinationID = 0;
                //find correct cities
                foreach (City city in db.Cities)
                {
                    if (city.CityID == ((ComboItem)originComboBox.SelectedItem).ID)
                    {
                        departingID = city.CityID;
                    }
                    if (city.CityID == ((ComboItem)destinationComboBox.SelectedItem).ID)
                    {
                        destinationID = city.CityID;
                    }
                }

                //Make a new ticket and add to top of form
                LoadEngineerTicketForm ticket = new LoadEngineerTicketForm(this);
                ticket.setUIValues(departingID, destinationID, null);
                ticket.TopLevel = false;
                ticket.Visible = true;
                flowLayoutPanel1.Controls.Add(ticket);
                flowLayoutPanel1.Controls.SetChildIndex(ticket, 0);
            }
        }

        //When this button is clicked, list relevant flights based on dates
        private async void browseFlightsMarketingButton_Click(object sender, EventArgs e)
        {
            //clear panel of previous elements before populating with new one
            flowLayoutPanel1.Controls.Clear();
            await displayRouteTickets();
        }

        //This displays tickets bsed on the parameters inputted
        public async Task displayRouteTickets()
        {
            //access database
            using (var db = new FlightContext())
            {
                //search database for applicable ID's and run algo
                int departingID = 0;
                int destinationID = 0;
                //find correct cities
                foreach (City city in db.Cities)
                {
                    
                    if (city.CityID == ((ComboItem)originComboBox.SelectedItem).ID)
                    {
                        departingID = city.CityID;
                    }
                    if (city.CityID == ((ComboItem)destinationComboBox.SelectedItem).ID)
                    {
                        destinationID = city.CityID;
                    }
                }

                //match routes up with cities selected from combobox
                var routes = await db.Routes
                    .Include(route => route.RouteOriginCity)
                    .Include(route => route.RouteDestinationCity)
                    .Where(route => route.RouteOriginCityID == departingID && route.RouteDestinationCityID == destinationID && !route.isCanceled).ToListAsync();
                    
                //make a ticket for each route and display
                foreach (Route route in routes)
                {
                    //make tickets for every route between these two cities
                    LoadEngineerTicketForm ticket = new LoadEngineerTicketForm(this, route);                    
                    ticket.setUIValues(departingID, destinationID, route.FlightDepartureTime.ToString(@"hh\:mm"));
                    ticket.TopLevel = false;
                    ticket.Visible = true;
                    flowLayoutPanel1.Controls.Add(ticket);
                }
            }
        }

        //logout user
        private void loadEngineerLogOutButton_Click(object sender, EventArgs e)
        {
            logoutClicked = true;
            this.Close();
            //log out of session
            CustomerSession.logout();
            loginFormParent.Visible = true;
        }
    }
}
