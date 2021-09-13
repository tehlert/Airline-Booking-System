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
using System.Text;
using System.Windows.Forms;

namespace Air3550
{
    //This is the top form for the browse flights tab for the customer
    public partial class BrowseFlightsTopForm : Form
    {
        //basic comboitem for combobox
        class ComboItem
        {
            public int ID { get; set; }
            public string Airport { get; set; }
        }
        //child form of the top parent, child is made and set in constructor
        public BrowseFlightsMainForm childBrowseFlightsMainForm;
        public BrowseFlightsTopForm()
        {
            InitializeComponent();
            childBrowseFlightsMainForm = new BrowseFlightsMainForm(this);
            List<ComboItem> comboItemsOrigin = new List<ComboItem>();
            List<ComboItem> comboItemsDestination = new List<ComboItem>();
            //set min date to today
            departingDateTimePicker.MinDate = DateTime.Today;
            returnDateTimePicker.MinDate = DateTime.Today;
            //populate origin combobox on startup
            using (var db = new FlightContext())
            {
                //Populate cities in database and add to comboboxes
                foreach (City city in db.Cities)
                {
                    comboItemsOrigin.Add(new ComboItem { ID = city.CityID, Airport = city.CityNameCode});
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




        //populate main form panel with flights
        private async void searchButton_Click(object sender, EventArgs e)
        {
            //clear panel
            childBrowseFlightsMainForm.clearFlowLayoutPanel();
            //clear routepaths is previously loaded
            childBrowseFlightsMainForm.clearroutePathsForFlight();
            await childBrowseFlightsMainForm.displayTickets(originComboBox.Text, destinationComboBox.Text, departingDateTimePicker.Value, returnDateTimePicker.Value, onewayRadioButton.Checked);
        }

        //when round trip make other destination visible
        private void roundTripRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            returnDateLabel.Visible = true;
            returnDateTimePicker.Visible = true;
        }
        //when one way clicked make destination not visible
        private void onewayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            returnDateLabel.Visible = false;
            returnDateTimePicker.Visible = false;
        }
    }
}
