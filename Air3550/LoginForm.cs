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
    //this is the login main form 
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        //exit button for login form
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //log in button
        private async void button1_Click(object sender, EventArgs e)
        {
            // Validate user name and password here
            using (var db = new FlightContext())
            {
                // singleOrdefault returns one customer or null, if no user found matching credentials, then display box
                var customer = db.Customers.SingleOrDefault(customer => customer.CustomerUsername == usernameText.Text);
                if (customer == null)
                {
                    MessageBox.Show("Invalid Login attempt");
                    return;
                }

                // Hash textbox and return the hashed value
                // Compare hashed value in database with new hashed value
                //if pasword wrong then display message
                if (!Hashing.Confirm(passwordText.Text, customer.CustomerPassword, Supported_HA.SHA512))
                {
                    MessageBox.Show("Invalid Login attempt");
                    return;
                }

                //log in user by setting values for customer session
                CustomerSession.Login(customer.CustomerID, customer.CustomerAccountLevel);
                //set form based on account level
                Form form = customer.CustomerAccountLevel switch
                {
                    AccountLevel.ACCOUNTANT => new AccountantForm(this),
                    AccountLevel.FLIGHT_MANAGER => new FlightManagerForm(this),
                    AccountLevel.LOAD_ENGINEER => new LoadEngineerForm(this),
                    AccountLevel.MARKETING_MANAGER => new MarketingManagerForm(this),
                    AccountLevel.CUSTOMER => new CustomerForm(this),
                    _ => throw new ArgumentException("Nonexisting AccountLevel"),
                };

                //If customer, look through transactions to see if they are passed date, if they are, add points
                if (customer.CustomerAccountLevel == AccountLevel.CUSTOMER)
                {
                    foreach (Transaction transaction in db.Transactions.Include(ticket => ticket.Tickets))
                    {
                        Flight firstFlightForTransaction = db.Flights.Single(flight => flight.FlightID == transaction.Tickets.First().FlightID);
                        DateTime flightDateTime = firstFlightForTransaction.FlightDate;
                        Route routeAssignedToFlight = db.Routes.Single(route => route.RouteID == firstFlightForTransaction.FlightRouteID);
                        TimeSpan flightTime = routeAssignedToFlight.FlightDepartureTime;
                        DateTime exactDepartureTime = new DateTime(flightDateTime.Year, flightDateTime.Month, flightDateTime.Day, flightTime.Hours, flightTime.Minutes, flightTime.Seconds);
                        //claim points if they are for the customer, have happenend in the past, and the ticket was not canceled
                        if ((transaction.TransactionCustomerID == customer.CustomerID && (DateTime.Compare(exactDepartureTime, DateTime.Now) < 0) && transaction.PointsClaimed == false) || (transaction.TransactionCustomerID == customer.CustomerID && transaction.isCanceled && transaction.PointsClaimed == false))
                        {
                            if (transaction.TransactionBillingType == "points")
                            {
                                //refund points
                                customer.CurrentPoints = customer.CurrentPoints + (int)transaction.TransactionTotalPrice;
                            }
                            else 
                            {
                                //They get 10 points per dollar
                                customer.CurrentPoints = customer.CurrentPoints + (int)transaction.TransactionTotalPrice * 10;
                                transaction.PointsClaimed = true;
                            }

                        }
                    }
                }
                //save changes
                await db.SaveChangesAsync();
                form.Show();
                this.Visible = false;
            }
        }

            //Create account button, display form
            private void button2_Click(object sender, EventArgs e)
            {
                this.Visible = false;
                CreateAccountForm accountForm = new CreateAccountForm(this);
                accountForm.ShowDialog();
            }
            
            //autogen code, do nothing
            private void LoginForm_Load(object sender, EventArgs e)
            {

            }
        }
    }