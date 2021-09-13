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
using System.Text;
using System.Windows.Forms;

namespace Air3550
{
    //This is the ticket class for the flightmanager form
    public partial class FlightManagerTicketForm : Form
    {
        //parent is set in constructor, list is also made to loop through
        public FlightManagerForm browseFlightManagerParent;
        List<Customer> customerListForFlight = new List<Customer>();
        public FlightManagerTicketForm(FlightManagerForm browseParent)
        {
            InitializeComponent();
            browseFlightManagerParent = browseParent;
        }

        //Show pop-up form with all customers listed
        private void printManifestButton_Click(object sender, EventArgs e)
        {
            //create new manifest form and show dialog
            PrintManifestForm manifestForm = new PrintManifestForm();
            manifestForm.addAndShowCustomers(customerListForFlight);
            manifestForm.ShowDialog();
        }

        //set UI values for the ticker
        public void setUIValues(String departDate, string origin, string destination, string ticketsSold, List<Customer> customerList, string flightNumber)
        {
            dateOfFlightLabel.Text = departDate;
            originAirportLabel.Text = origin;
            destinationAirportLabel.Text = destination;
            numberOfPassengersLabel.Text = ticketsSold;
            customerListForFlight = customerList;
            flightNumberLabel.Text = flightNumber;
        }
    }
}
