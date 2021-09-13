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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air3550.Database.Models
{
    //Model for the ticket, includes flight related to it, the transaction related to it, as well as an iscanceld flag for logic
    public class Ticket
    {
        public int TicketId { get; set; }
        public int FlightID { get; set; }
        [Required]
        public Flight Flight { get; set; }
        [Required]
        public Transaction Transaction { get; set; }
        public bool IsCanceled { get; set; }
    }
}
