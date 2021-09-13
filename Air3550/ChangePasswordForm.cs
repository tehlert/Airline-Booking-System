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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air3550
{
    //This is a popup form for when the change password button is clicked
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        //Check values and save changes
        private void saveChangeButton_Click(object sender, EventArgs e)
        {
            //resetHighlightBoxColors
            conFirmPasswordOutline.BackColor = Color.FromArgb(24, 22, 31);
            newPasswordOutline.BackColor = Color.FromArgb(24, 22, 31);
            originalPaswordOutline.BackColor = Color.FromArgb(24, 22, 31);

            //Access DB and check if the password is the same, if it is, set new password hash
            using (var db = new FlightContext())
            {
                var customer = db.Customers.Single(customer => customer.CustomerID == CustomerSession.CUSTOMER_ID);

                //if original password not entered, show pop-up and highlight
                if (!Hashing.Confirm(orginalPasswordTextBox.Text, customer.CustomerPassword, Supported_HA.SHA512))
                {
                    MessageBox.Show("Original password was entered correctly");
                    originalPaswordOutline.BackColor = Color.Red;
                    return;
                }

                //if confirm passwords do not match, show popup
                if (confirmPasswordTextBox.Text != newPasswordTextBox.Text)
                {
                    conFirmPasswordOutline.BackColor = Color.Red;
                    newPasswordOutline.BackColor = Color.Red;
                    MessageBox.Show("Passwords do not match");
                    return;
                }

                //original password is right and the new pasword text boxes are the same, save and store
                customer.CustomerPassword = Hashing.ComputeHash(confirmPasswordTextBox.Text, Supported_HA.SHA512, null);
                db.SaveChanges();
                MessageBox.Show("Password Saved!");
                this.Close();
            }
        }

        //close form
        private void discardChangesButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
