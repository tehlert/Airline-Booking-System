/*
 Air 3550 Project Team 7

This program is a basic flight reservation system for a fake airline company
It allows customers to book, manage, cancel, and browse flights within a database.
It also allows employee accounts to update and manage flights and view business statistics.

Written by: Harrison Kania, Tyler Ehlert, Daniel Wellons
For EECS3550-001 Software Engineering, Instructor: Dr. Thomas 
 */
using Air3550.Database.Models;
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
    //basic manifest form that is called when the flight manager hits the print manifest button
    public partial class PrintManifestForm : Form
    {
        public PrintManifestForm()
        {
            InitializeComponent();
        }

        //do nothing here, autogen
        private void manifestFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        //add tickets to panel to display customers
        public void addAndShowCustomers(List<Customer> customerList)
        {
            foreach (Customer customer in customerList)
            {
                ManifestTicketForm ticketForm = new ManifestTicketForm();
                ticketForm.setUIValues(customer.CustomerFirstName, customer.CustomerLastName);
                ticketForm.TopLevel = false;
                ticketForm.Visible = true;
                manifestFlowLayoutPanel.Controls.Add(ticketForm);
            }
        }
    }
}
