/*
 Air 3550 Project Team 7

This program is a basic flight reservation system for a fake airline company
It allows customers to book, manage, cancel, and browse flights within a database.
It also allows employee accounts to update and manage flights and view business statistics.

Written by: Harrison Kania, Tyler Ehlert, Daniel Wellons
For EECS3550-001 Software Engineering, Instructor: Dr. Thomas 
 */
using Air3550.Database.Context;
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
    //Top part of the history form, just display used points here
    public partial class flightHistoryTopForm : Form
    {
        //parent and child set in construstor
        public FlightHistoryMainForm mainForm;
        public CustomerForm customerForm;
        public flightHistoryTopForm(CustomerForm topParent)
        {
            InitializeComponent();
            customerForm = topParent;
            mainForm= new FlightHistoryMainForm(this);

            //set label based on correct customer in db
            using (var db = new FlightContext())
            {
                var customer = db.Customers.Single(customer => customer.CustomerID == CustomerSession.CUSTOMER_ID);
                pointsUsedLabel.Text = "Points Used " + customer.UsedPoints;

            }
        }

        //do nothing here, autogen
        private void flightHistoryTopForm_Load(object sender, EventArgs e)
        {

        }
        //do nothing here, autogen
        private void pointsUsedLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
