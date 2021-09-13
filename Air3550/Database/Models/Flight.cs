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
    //model for flight, include the id, date of flight, route id, actual route associated with flight, and tickets assigned to the flight scheduled
    public class Flight
    {
        public int FlightID { get; set; }
        [Required]
        public DateTime FlightDate { get; set; }

        public int FlightRouteID { get; set; }
        [Required]
        public Route FlightRoute { get; set; }
        public List<Ticket> Tickets { get; }
    }
}
