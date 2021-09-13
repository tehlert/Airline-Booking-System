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
    //this is the ticketform for the load engineer
    public partial class LoadEngineerTicketForm : Form
    {

        //basic comboitem
        public class ComboItem
        {
            public int ID { get; set; }
            public string Airport { get; set; }
        }
        
        //variables for manipulation
        private int originalOrigin;
        private int originalDestination;
        private String originalDepartureTime;
        bool isNewFlight = false;

        public LoadEngineerForm parentEngineerForm;
        Route routeForTicket;

        //constructor populates comboboxes and makes form
        public LoadEngineerTicketForm(LoadEngineerForm parentForm, Route route)
        {       
            InitializeComponent();
            parentEngineerForm = parentForm;
            routeForTicket = route;
            //populate combobox with the correct info
            using (var db = new FlightContext())
            {
                List<ComboItem> comboItemsOrigin = new List<ComboItem>();
                List<ComboItem> comboItemsDestination = new List<ComboItem>();
                //Populate cities in database
                foreach (City city in db.Cities)
                {
                    comboItemsOrigin.Add(new ComboItem { ID = city.CityID, Airport = city.CityNameCode });
                    comboItemsDestination.Add(new ComboItem { ID = city.CityID, Airport = city.CityNameCode });
                }

                originEngineerComboBox.DataSource = comboItemsOrigin;
                destinationEngineerComboBox.DataSource = comboItemsDestination;

                originEngineerComboBox.DisplayMember = "Airport";
                originEngineerComboBox.ValueMember = "ID";
                originEngineerComboBox.MaxDropDownItems = 8;

                destinationEngineerComboBox.DisplayMember = "Airport";
                destinationEngineerComboBox.ValueMember = "ID";
                destinationEngineerComboBox.MaxDropDownItems = 8;
            }
        }

        //This constructor is for adding a new flight, same as original but make fields editable
        public LoadEngineerTicketForm(LoadEngineerForm loadEngineerForm)
        {
            parentEngineerForm = loadEngineerForm;
            InitializeComponent();
            isNewFlight = true;
            //populate combobox with the correct info
            using (var db = new FlightContext())
            {
                List<ComboItem> comboItemsOrigin = new List<ComboItem>();
                List<ComboItem> comboItemsDestination = new List<ComboItem>();
                //Populate cities in database
                foreach (City city in db.Cities)
                {
                    comboItemsOrigin.Add(new ComboItem { ID = city.CityID, Airport = city.CityNameCode });
                    comboItemsDestination.Add(new ComboItem { ID = city.CityID, Airport = city.CityNameCode });
                }

                originEngineerComboBox.DataSource = comboItemsOrigin;
                destinationEngineerComboBox.DataSource = comboItemsDestination;

                originEngineerComboBox.DisplayMember = "Airport";
                originEngineerComboBox.ValueMember = "ID";
                originEngineerComboBox.MaxDropDownItems = 8;

                destinationEngineerComboBox.DisplayMember = "Airport";
                destinationEngineerComboBox.ValueMember = "ID";
                destinationEngineerComboBox.MaxDropDownItems = 8;
            }
        }

        //edit button
        private void editFlightButton_Click(object sender, EventArgs e)
        {
            //Make fields editable
            destinationEngineerComboBox.Enabled = true;
            originEngineerComboBox.Enabled = true;
            saveChangesEngineerButton.Visible = true;
            discardChangesEngineerButton.Visible = true;
            flightTimeEngineerTextBox.Enabled = true;
            deleteFlightButton.Visible = true;
            originalOrigin = ((ComboItem)originEngineerComboBox.SelectedItem).ID;
            originalDestination = ((ComboItem)destinationEngineerComboBox.SelectedItem).ID;
            originalDepartureTime = flightTimeEngineerTextBox.Text;
            editFlightButton.Enabled = false;
        }

        //save changes button

        private async void saveChangesEngineerButton_Click(object sender, EventArgs e)
        {
            //Check if timespan is formatted correctly, if not display message box
            TimeSpan timeSpanForRoute = new TimeSpan(0, 0, 0);
            try
            {
               timeSpanForRoute = TimeSpan.Parse(flightTimeEngineerTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("time span is inputted incorrectly, format should ideally be HH:MM");
                return;
            }
            catch(OverflowException)
            {
                MessageBox.Show("time span is inputted incorrectly, format should ideally be HH:MM");
                return;
            }
            destinationEngineerComboBox.Enabled = false;
            originEngineerComboBox.Enabled = false;
            saveChangesEngineerButton.Visible = false;
            discardChangesEngineerButton.Visible = false;
            deleteFlightButton.Visible = false;
            flightTimeEngineerTextBox.Enabled = false;
            //Check if any changes have been made, if not then leave as is
            if (((ComboItem)originEngineerComboBox.SelectedItem).ID == originalOrigin && ((ComboItem)destinationEngineerComboBox.SelectedItem).ID == originalDestination && originalDepartureTime.Equals(flightTimeEngineerTextBox.Text))
            {
                //set orginal values back
                originEngineerComboBox.SelectedIndex = originalOrigin - 1;
                destinationEngineerComboBox.SelectedIndex = originalDestination - 1;
                flightTimeEngineerTextBox.Text = originalDepartureTime;
            }
            //If there has been a change, cancel the original route and add a new route to the db with the selected values and refresh the page
            //This is to ensure that no flights are changed around for a customer
            else
            {
                //access database
                using (var db = new FlightContext())
                {
                    //check to see if brand new route being saved
                    if (routeForTicket != null)
                    {
                        Route routeInDB = db.Routes.Single(route => route.RouteID == routeForTicket.RouteID);
                        routeInDB.isCanceled = true;
                    }
                    City originCity = db.Cities.Single(city => city.CityNameCode == originEngineerComboBox.Text);
                    City destinationCity = db.Cities.Single(city => city.CityNameCode == destinationEngineerComboBox.Text);
                    Aircraft aircraft = db.Aircrafts.Single(aircraft => aircraft.AircraftID == 1);

                    // create a new route 
                    var newRoute = new Route
                    {
                        RouteOriginCityID = originCity.CityID,
                        RouteOriginCity = originCity,
                        RouteDestinationCityID = destinationCity.CityID,
                        RouteDestinationCity = destinationCity,
                        FlightAircraft = aircraft,
                        FlightDepartureTime = timeSpanForRoute
                    };
                    routeForTicket = newRoute;
                    // Write new route to db
                    await db.AddAsync(newRoute);
                    //save all changes to db
                    await db.SaveChangesAsync();
                    routeForTicket = newRoute;
                }
            }
            //enable edit button again
            editFlightButton.Enabled = true;
            //once saved, the flight is not brand new so reset flag
            if (isNewFlight)
            {
                isNewFlight = false;
            }
        }

        //discard button
        private void discardChangesEngineerButton_Click(object sender, EventArgs e)
        {
            //if it is a new flight, just get rid of form
            if (isNewFlight)
            {
                this.Visible = false;
                return;
            }
            //set orginal values back
            originEngineerComboBox.SelectedIndex = originalOrigin - 1;
            destinationEngineerComboBox.SelectedIndex = originalDestination - 1;
            flightTimeEngineerTextBox.Text = originalDepartureTime;
            //disable fields
            destinationEngineerComboBox.Enabled = false;
            originEngineerComboBox.Enabled = false;
            saveChangesEngineerButton.Visible = false;
            discardChangesEngineerButton.Visible = false;
            deleteFlightButton.Visible = false;
            flightTimeEngineerTextBox.Enabled = false;
            editFlightButton.Enabled = true;


        }

        // set to cancelled
        private async void deleteFlightButton_Click(object sender, EventArgs e)
        {
            if (isNewFlight)
            {
                this.Visible = false;
                return;
            }
            //access database, set flag, and hide from panel
            using (var db = new FlightContext())
            {
                Route routeInDB = db.Routes.Single(route => route.RouteID == routeForTicket.RouteID);
                routeInDB.isCanceled = true;
                await db.SaveChangesAsync();
            }
            this.Visible = false;
        }

        //close the flowpanel ticket
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        //do nothing, autogen code
        private void destinationEngineerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        //set all appicable values for the ticket
        public void setUIValues(int originID, int destinationID, string departureTime)
        {
            //if new flight, set values and make fields editable 
            if (departureTime == null)
            {
                //set correct indexes
                originEngineerComboBox.SelectedIndex = originID - 1;
                destinationEngineerComboBox.SelectedIndex = destinationID - 1;
                //Make fields editable
                destinationEngineerComboBox.Enabled = true;
                originEngineerComboBox.Enabled = true;
                saveChangesEngineerButton.Visible = true;
                discardChangesEngineerButton.Visible = true;
                flightTimeEngineerTextBox.Enabled = true;
                deleteFlightButton.Visible = true;
                originalOrigin = ((ComboItem)originEngineerComboBox.SelectedItem).ID;
                originalDestination = ((ComboItem)destinationEngineerComboBox.SelectedItem).ID;
                originalDepartureTime = flightTimeEngineerTextBox.Text;
                editFlightButton.Enabled = false;
            }
            else
            {
                // use selected index because the index of the cities never change and we load the comboboxes on init
                originEngineerComboBox.SelectedIndex = originID - 1;
                destinationEngineerComboBox.SelectedIndex = destinationID - 1;
                flightTimeEngineerTextBox.Text = departureTime;
            }
        }      
    }
}
