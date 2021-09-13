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
    //Model for customer, includes the id, account level, username, password, first and last name, address, number, age ,credit number
    //Also includes the current points and used points
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required]
        public AccountLevel CustomerAccountLevel { get; set; }
        [Required]
        public string CustomerUsername { get; set; }
        [Required]
        public string CustomerPassword { get; set; }
        [Required]
        public string CustomerFirstName { get; set; }
        [Required]
        public string CustomerLastName { get; set; }
        [Required]
        public string CustomerAddress { get; set; }
        [Required]
        public string CustomerPhoneNumber { get; set; }
        [Required]
        public int CustomerAge { get; set; }
        [Required]
        public string CustomerCreditCardNumber { get; set; }
        [Required]
        public int CurrentPoints { get; set; }

        public int UsedPoints { get; set; }
    }
}
