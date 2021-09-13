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
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Air3550
{
    //this is the main form for the marketing manager
    public partial class MarketingManagerForm : Form
    {
        //basic comboitem
        public class ComboItem
        {
            public int ID { get; set; }
            public string Airport { get; set; }
        }
        LoginForm loginFormParent;
        public bool logoutClicked = false;

        //on construction, populate comboboxes and make form
        public MarketingManagerForm(LoginForm loginForm)
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
        //override so application can exit properly
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (!logoutClicked)
            {
                Application.Exit();
            }
        }


        //populate panel with relevant tickets
        private async void browseFlightsMarketingButton_Click(object sender, EventArgs e)
        {
            marketingFlowLayoutPanel.Controls.Clear();
            using (var db = new FlightContext())
            {
                // loop through and get all routes with relevant info mathching combobox parameters
                var routes = await db.Routes
                .Include(route => route.RouteOriginCity)
                .Include(route => route.RouteDestinationCity)
                .Include(route => route.FlightAircraft)
                .Where(route => route.RouteOriginCityID == ((ComboItem)originComboBox.SelectedItem).ID && route.RouteDestinationCityID == ((ComboItem)destinationComboBox.SelectedItem).ID && !route.isCanceled).ToListAsync();
                foreach (Route route in routes)
                {
                    //make the ticket, set its values,  and add to the panel
                    MarketingManagerTicketForm ticketForm = new MarketingManagerTicketForm(this, route);
                    ticketForm.setUIValues(route.FlightDepartureTime, route.RouteOriginCity.CityNameCode, route.RouteDestinationCity.CityNameCode, route.FlightAircraft.AircraftID);

                    ticketForm.TopLevel = false;
                    ticketForm.Visible = true;
                    marketingFlowLayoutPanel.Controls.Add(ticketForm);
                }
            }                        
        }

        private void accountantExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Clear the flow layout panel
        private void clearPanelButton_Click(object sender, EventArgs e)
        {
            marketingFlowLayoutPanel.Controls.Clear();
        }

        private void marketingManagerLogOutButton_Click(object sender, EventArgs e)
        {
            logoutClicked = true;
            this.Close();
            CustomerSession.logout();
            loginFormParent.Visible = true;
        }
    }
}
