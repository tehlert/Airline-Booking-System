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
    //Accountlevel to determine what form to generate on login
    public enum AccountLevel
    {
        CUSTOMER,
        ACCOUNTANT,
        LOAD_ENGINEER,
        MARKETING_MANAGER,
        FLIGHT_MANAGER
    }
}
