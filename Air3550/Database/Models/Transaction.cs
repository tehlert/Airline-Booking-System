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
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Air3550.Database.Models
{
    //Model for transaction, includes a list of tickets for the transaction, the booking and departure date, the customer, the total price, the billing type
    //a points claimed flag, and an iscanceled flag
    public class Transaction
    {
        public int TransactionID { get; set; }
        public List<Ticket> Tickets { get; } = new();
        [Required]
        public DateTime TransactionBookingDate { get; set; }
        [Required]
        public DateTime TransactionDepartureDate { get; set; }
        public int TransactionCustomerID { get; set; }
        [Required]
        public Customer TransactionCustomer { get; set; }
        [Required]
        public string TransactionType { get; set; }
        [Required]
        public decimal TransactionTotalPrice { get; set; }
        [Required]
        public string TransactionBillingType { get; set; }
        [Required]
        public bool PointsClaimed { get; set; }
        [Required]
        public bool isCanceled { get; set; }
    }
}
