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
    //This is a ticket form for the marketing manager to assign planes to flight
    public partial class MarketingManagerTicketForm : Form
    {

        //basic comboitem for form
        class ComboItem
        {
            public int ID { get; set; }
            public string Airplane { get; set; }
        }
        
        //variables for manipulation
        private ComboItem originalItem;
        public Route routeAssignedToTicket;
        public MarketingManagerForm browseMarketingManagerParent;

        //constructor makes ticket and setst the correct aircraft in the combo box
        public MarketingManagerTicketForm(MarketingManagerForm browseParent, Route route)
        {
            InitializeComponent();
            routeAssignedToTicket = route;
            browseMarketingManagerParent = browseParent;

            //populate combobox for planes
            List<ComboItem> comboItemsPlane = new List<ComboItem>();
            //populate origin combobox on startup
            using (var db = new FlightContext())
            {
                //Populate cities in combobox from database
                foreach (Aircraft plane in db.Aircrafts)
                {
                    comboItemsPlane.Add(new ComboItem { ID = plane.AircraftID, Airplane = plane.AircraftName });
                }
                planeAssignedComboBox.DataSource = comboItemsPlane;

                planeAssignedComboBox.DisplayMember = "Airplane";
                planeAssignedComboBox.ValueMember = "ID";
                planeAssignedComboBox.MaxDropDownItems = 5;
            }
        }

        // Set ticket values and aircraft
        public void setUIValues(TimeSpan departTime, string origin, string destination, int aircraftID)
        {
            routeTimeLabel.Text = departTime.ToString(@"hh\:mm");
            originAirportLabel.Text = origin;
            destinationAirportLabel.Text = destination;
            planeAssignedComboBox.SelectedIndex = aircraftID - 1;
        }

        //Make combobox editable 
        private void assignPlaneButton_Click(object sender, EventArgs e)
        {
            originalItem = ((ComboItem)planeAssignedComboBox.SelectedItem);
            planeAssignedComboBox.Enabled = true;
            saveChangesButton.Visible = true; 
            cancelChangesButton.Visible = true;
            assignPlaneButton.Enabled = false;
        }

        //save changes button to save the changes to the database wehn clicked
        private async void saveChangesButton_Click(object sender, EventArgs e)
        {
            planeAssignedComboBox.Enabled = false;
            saveChangesButton.Visible = false;
            cancelChangesButton.Visible = false;
            assignPlaneButton.Enabled = true;

            //access dB
            using (var db = new FlightContext())
            {
                Aircraft aircraft = db.Aircrafts.Single(aircraft => aircraft.AircraftID == ((ComboItem)planeAssignedComboBox.SelectedItem).ID);
                Route routeInDB = db.Routes.Single(route => route.RouteID == routeAssignedToTicket.RouteID);

                routeInDB.FlightAircraft = aircraft;

                await db.SaveChangesAsync();
            }
        }

        //reset values to defauly and make not editable
        private void cancelChangesButton_Click(object sender, EventArgs e)
        {
            planeAssignedComboBox.SelectedItem = originalItem;
            planeAssignedComboBox.Enabled = false;
            saveChangesButton.Visible = false;
            cancelChangesButton.Visible = false;
            assignPlaneButton.Enabled = true;
        }
    }
}
