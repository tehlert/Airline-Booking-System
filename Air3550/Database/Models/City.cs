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
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Air3550.Database.Models
{
    //City model, include the id, namecode(CLE,DTW), name, latitude, and longitude for distance calculations
    public class City
    {
        public int CityID { get; set; }
        [Required]
        public string CityNameCode { get; set; }
        [Required]
        public string CityName { get; set; }
        [Required]
        [Column(TypeName = "Decimal(8,6)")]
        public decimal CityLatitude { get; set; }
        [Required]
        [Column(TypeName = "Decimal(9,6)")]
        public decimal CityLongitude { get; set; }

    }
}
