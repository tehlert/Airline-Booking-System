/*
 Air 3550 Project Team 7

This program is a basic flight reservation system for a fake airline company
It allows customers to book, manage, cancel, and browse flights within a database.
It also allows employee accounts to update and manage flights and view business statistics.

Written by: Harrison Kania, Tyler Ehlert, Daniel Wellons
For EECS3550-001 Software Engineering, Instructor: Dr. Thomas 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Air3550
{
    //This is the top form for the account info tab for the customer
    public partial class AccountInfoTopForm : Form
    {
        //parent is set in constructor
        public AccountInfoMainForm childAccountInfoMainForm;
        public AccountInfoTopForm()
        {
            InitializeComponent();
            childAccountInfoMainForm = new AccountInfoMainForm(this);
        }
        //If button is clicked, enable text
        private void changeAccountInfoButton_Click(object sender, EventArgs e)
        {
            childAccountInfoMainForm.enableText();
        }
    }
}
