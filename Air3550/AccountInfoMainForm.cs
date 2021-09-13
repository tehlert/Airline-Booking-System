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
    //Class that is the main form for the account info button for the customer
    public partial class AccountInfoMainForm : Form
    {
        //parent is assigned on initialzation
        AccountInfoTopForm topAccountInfoForm;
        public AccountInfoMainForm(AccountInfoTopForm infoTopParent)
        {
            InitializeComponent();
            topAccountInfoForm = infoTopParent;
            //set values of boxes
            using (var db = new FlightContext())
            {
                var customer = db.Customers.Single(customer => customer.CustomerID == CustomerSession.CUSTOMER_ID);
                //Set values here from database
                pointsLabel.Text = "Points: " + customer.CurrentPoints;
                nameText.Text = customer.CustomerFirstName;
                lastNameText.Text = customer.CustomerLastName;
                addressText.Text = customer.CustomerAddress;
                phoneText.Text = customer.CustomerPhoneNumber;
                ageText.Text = customer.CustomerAge.ToString();
                billingText.Text = customer.CustomerCreditCardNumber;
            }

        }

        
        String nameTextOriginal;
        String lastNameTextOriginal;
        String addressTextOriginal;
        String phoneTextOriginal;
        String passwordTextOriginal;
        String ageTextOriginal;
        String billingTextOriginal;
        //Make fields editable and save original values
        public void enableText()
        {
            nameTextOriginal = nameText.Text;
            lastNameTextOriginal = lastNameText.Text;
            addressTextOriginal = addressText.Text;
            phoneTextOriginal = phoneText.Text;
            ageTextOriginal = ageText.Text;
            billingTextOriginal = billingText.Text;
            nameText.ReadOnly = false;
            lastNameText.ReadOnly = false;
            addressText.ReadOnly = false;
            phoneText.ReadOnly = false;
            ageText.ReadOnly = false;
            billingText.ReadOnly = false;
            saveChangeButton.Visible = true;
            discardChangesButton.Visible = true;
            topAccountInfoForm.changeAccountInfoButton.Enabled = false;

        }

        //eye icon, do nothing (auto generated)
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        //save changes button, will save changes to db from fields entered
        private async void button1_Click(object sender, EventArgs e)
        {
            bool isFieldWrong = false;
            //reset highlight box colors
            nameOutline.BackColor = Color.FromArgb(24, 22, 31);
            addressOutline.BackColor = Color.FromArgb(24, 22, 31);
            ageOutline.BackColor = Color.FromArgb(24, 22, 31);
            billingOutline.BackColor = Color.FromArgb(24, 22, 31);
            numberOutline.BackColor = Color.FromArgb(24, 22, 31);
            lastNameOutline.BackColor = Color.FromArgb(24, 22, 31);

            //Checks to verify fields are entered
            if (string.IsNullOrWhiteSpace(nameText.Text))
            {
                isFieldWrong = true;
                nameOutline.BackColor = Color.Red;
            }

            if (string.IsNullOrWhiteSpace(lastNameText.Text))
            {
                isFieldWrong = true;
                lastNameOutline.BackColor = Color.Red;
            }
            // check age
            int Age = 0;
            bool ageValid = int.TryParse(ageText.Text, out Age);
            if (Age < 1 || Age > 150)
            {
                isFieldWrong = true;
                ageOutline.BackColor = Color.Red;
            }

            if (string.IsNullOrWhiteSpace(addressText.Text))
            {
                isFieldWrong = true;
                addressOutline.BackColor = Color.Red;
            }


            if (string.IsNullOrWhiteSpace(billingText.Text))
            {
                isFieldWrong = true;
                billingOutline.BackColor = Color.Red;
            }

            if (string.IsNullOrWhiteSpace(phoneText.Text))
            {
                isFieldWrong = true;
                numberOutline.BackColor = Color.Red;
            }

            //If a field is wrong, display box to prompt for changes
            if (isFieldWrong)
            {
                MessageBox.Show("Please fill in all fields highlighted correctly");
            }
            else
            {
                //If all fields are right, store in database and make not editable
                using (var db = new FlightContext())
                {
                    var customer = db.Customers.Single(customer => customer.CustomerID == CustomerSession.CUSTOMER_ID);
                    customer.CustomerFirstName = nameText.Text;
                    customer.CustomerLastName = lastNameText.Text;
                    customer.CustomerPhoneNumber = phoneText.Text;
                    customer.CustomerAddress = addressText.Text;
                    customer.CustomerAge = Age;
                    customer.CustomerCreditCardNumber = billingText.Text;

                    await db.SaveChangesAsync();

                }
                //reset fields to not editable
                nameText.ReadOnly = true;
                lastNameText.ReadOnly = true;
                addressText.ReadOnly = true;
                phoneText.ReadOnly = true;
                ageText.ReadOnly = true;
                billingText.ReadOnly = true;
                //make things not visible
                saveChangeButton.Visible = false;
                discardChangesButton.Visible = false;
                topAccountInfoForm.changeAccountInfoButton.FlatAppearance.BorderSize = 0;
                topAccountInfoForm.changeAccountInfoButton.Enabled = true;
            }
        }
        //Set original values back and discard changes
        public void discardChanges()
        {
            nameText.Text = nameTextOriginal;
            lastNameText.Text = lastNameTextOriginal;
            addressText.Text = addressTextOriginal;
            phoneText.Text = phoneTextOriginal;
            ageText.Text = ageTextOriginal;
            billingText.Text = billingTextOriginal;
            //reset highlight box colors
            nameOutline.BackColor = Color.FromArgb(24, 22, 31);
            addressOutline.BackColor = Color.FromArgb(24, 22, 31);
            ageOutline.BackColor = Color.FromArgb(24, 22, 31);
            billingOutline.BackColor = Color.FromArgb(24, 22, 31);
            numberOutline.BackColor = Color.FromArgb(24, 22, 31);
            lastNameOutline.BackColor = Color.FromArgb(24, 22, 31);

            nameText.ReadOnly = true;
            lastNameText.ReadOnly = true;
            addressText.ReadOnly = true;
            phoneText.ReadOnly = true;
            ageText.ReadOnly = true;
            billingText.ReadOnly = true;

            //make things not visible

            saveChangeButton.Visible = false;
            discardChangesButton.Visible = false;
            topAccountInfoForm.changeAccountInfoButton.FlatAppearance.BorderSize = 0;
            topAccountInfoForm.changeAccountInfoButton.Enabled = true;
        }
        //discard changes button, return fields to the original values
        private void discardChangesButton_Click(object sender, EventArgs e)
        {
            discardChanges();
        }

        //pop up dialog with change password form
        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changeForm = new ChangePasswordForm();
            changeForm.ShowDialog();
        }
    }
}
