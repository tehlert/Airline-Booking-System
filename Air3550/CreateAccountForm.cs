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
    //This is the create account form pop-up for when the button is clicked on the login page
    public partial class CreateAccountForm : Form
    {
        //parent set in constructor
        LoginForm loginFormParent;
        public CreateAccountForm(LoginForm loginForm)
        {
            InitializeComponent();
            loginFormParent = loginForm;
        }
        public bool createAccountClicked = false;
        //override so login form can pop back up or application can close correctly
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (!createAccountClicked)
            {
                loginFormParent.Visible = true;
            }
        }
        //CreateAccountButton, when clicked validate form, if valid then store customer in DB
        private async void button2_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                //if form is validated, create a new id and assign it, and store customer
                createAccountClicked = true;
                using (var db = new FlightContext())
                {
                    Random random = new Random();

                    string generateID;

                    while (true)
                    {
                        //keep generating ID's until a valid one is generated
                        generateID = random.Next(100_000, 1_000_000).ToString();
                        if (await db.Customers.SingleOrDefaultAsync(customer => customer.CustomerUsername == generateID) == null)
                        {
                            break;
                        }
                    }
                    int.TryParse(ageText.Text, out int Age);

                    //create a new customer
                    var customer = new Customer
                    {
                        CustomerAccountLevel = AccountLevel.CUSTOMER,
                        CustomerUsername = generateID,                        
                        CustomerPassword = Hashing.ComputeHash(passwordText.Text, Supported_HA.SHA512, null),
                        CustomerFirstName = nameText.Text,
                        CustomerLastName = lastNameText.Text,
                        CustomerPhoneNumber = phoneText.Text,
                        CustomerAddress = addressText.Text,
                        CustomerAge = Age,
                        CustomerCreditCardNumber = billingText.Text,
                        CurrentPoints = 0
                    };

                    //add and save changes
                    await db.AddAsync(customer);

                    await db.SaveChangesAsync();
                    CustomerSession.Login(customer.CustomerID, customer.CustomerAccountLevel);
                }


                // redirect to new customer page
                CustomerForm customerForm = new CustomerForm(loginFormParent);
                customerForm.Show();
                this.Close();
            }
            //if a field is wrong show pop-up message
            else
            {
                MessageBox.Show("This form has invalid entries. Please try again.");
            }

        }

        private bool ValidateForm()
        {
            bool isFieldWrong = false;
            //reset highlight box colors
            nameOutline.BackColor            = Color.FromArgb(24, 22, 31);
            addressOutline.BackColor         = Color.FromArgb(24, 22, 31);
            ageOutline.BackColor             = Color.FromArgb(24, 22, 31);
            passwordOutline.BackColor        = Color.FromArgb(24, 22, 31);
            billingOutline.BackColor         = Color.FromArgb(24, 22, 31);
            numberOutline.BackColor          = Color.FromArgb(24, 22, 31);
            lastNameOutline.BackColor        = Color.FromArgb(24, 22, 31);
            confirmPasswordOutline.BackColor = Color.FromArgb(24, 22, 31);

            // check password       
            if (passwordText.Text != confirmPasswordText.Text)
            {
                isFieldWrong = true;
                passwordOutline.BackColor = Color.Red;
                confirmPasswordOutline.BackColor = Color.Red;
            }

            //checks to see if fields were entered correctly
            if (string.IsNullOrWhiteSpace(passwordText.Text))
            {
                isFieldWrong = true;
                passwordOutline.BackColor = Color.Red;
            }

            if (string.IsNullOrWhiteSpace(confirmPasswordText.Text))
            {
                isFieldWrong = true;
                confirmPasswordOutline.BackColor = Color.Red;
            }
            // check firstname
            if (string.IsNullOrWhiteSpace(nameText.Text))
            {
                isFieldWrong = true;
                nameOutline.BackColor = Color.Red;
            }
            // check lastname
            if (string.IsNullOrWhiteSpace(lastNameText.Text))
            {
                isFieldWrong = true;
                lastNameOutline.BackColor = Color.Red;
            }
            // check age
            int Age = 0;
            bool ageValid = int.TryParse(ageText.Text, out Age);
            if (Age < 1 || Age > 100)
            {
                isFieldWrong = true;
                ageOutline.BackColor = Color.Red;
            }
            // check address
            if (string.IsNullOrWhiteSpace(addressText.Text))
            {
                isFieldWrong = true;
                addressOutline.BackColor = Color.Red;
            }
            // check billing
            if (string.IsNullOrWhiteSpace(billingText.Text))
            {
                isFieldWrong = true;
                billingOutline.BackColor = Color.Red;
            }        
            
            // check phone number
            if (string.IsNullOrWhiteSpace(phoneText.Text))
            {
                isFieldWrong = true;
                numberOutline.BackColor = Color.Red;
            }

            return isFieldWrong;
        }

        //Exit button
        private void button3_Click(object sender, EventArgs e)
        {
            //close window
            this.Close();
        }

        //autogenerated code, do nothing
        private void nameText_TextChanged(object sender, EventArgs e)
        {

        }

        //eye button, show password or hide
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(passwordText.UseSystemPasswordChar == true)
            {
                passwordText.UseSystemPasswordChar = false;
            }
            else
            {
                passwordText.UseSystemPasswordChar = true;
            }
        }

    }
}
