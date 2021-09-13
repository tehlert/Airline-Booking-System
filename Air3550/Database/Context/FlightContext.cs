/*
 Air 3550 Project Team 7

This program is a basic flight reservation system for a fake airline company
It allows customers to book, manage, cancel, and browse flights within a database.
It also allows employee accounts to update and manage flights and view business statistics.

Written by: Harrison Kania, Tyler Ehlert, Daniel Wellons
For EECS3550-001 Software Engineering, Instructor: Dr. Thomas 
 */
using Air3550.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Air3550.Database.Context
{
    public class FlightContext : DbContext
    {
        //Make database sets for each model
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        //use sqllite
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=Air3550.db");
        
        //This is where we populate the initial database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //make cities
            modelBuilder.Entity<City>().HasData(
                new City { CityID = 1, CityNameCode = "ATL", CityName = "Atlanta", CityLatitude = 33.636667m, CityLongitude = -84.428056m },
                new City { CityID = 2, CityNameCode = "BNA", CityName = "Nashville", CityLatitude = 36.126667m, CityLongitude = -86.681944m },
                new City { CityID = 3, CityNameCode = "CLE", CityName = "Cleveland", CityLatitude = 41.411667m, CityLongitude = -81.849722m },
                new City { CityID = 4, CityNameCode = "DEN", CityName = "Denver", CityLatitude = 39.861667m, CityLongitude = -104.673056m },
                new City { CityID = 5, CityNameCode = "DFW", CityName = "Dallas", CityLatitude = 32.896944m, CityLongitude = -97.038056m },
                new City { CityID = 6, CityNameCode = "DTW", CityName = "Detroit", CityLatitude = 42.2125m, CityLongitude = -83.353333m },
                new City { CityID = 7, CityNameCode = "FLL", CityName = "Fort Lauderdale", CityLatitude = 26.0725m, CityLongitude = -80.152778m },
                new City { CityID = 8, CityNameCode = "LGA", CityName = "Queens", CityLatitude = 40.775m, CityLongitude = -73.875m },
                new City { CityID = 9, CityNameCode = "LAX", CityName = "Los Angeles", CityLatitude = 33.9425m, CityLongitude = -118.408056m },
                new City { CityID = 10, CityNameCode = "ORD", CityName = "Chicago", CityLatitude = 41.978611m, CityLongitude = -87.904722m },
                new City { CityID = 11, CityNameCode = "SEA", CityName = "Seattle", CityLatitude = 47.448889m, CityLongitude = -122.309444m }
                );

            //Make aircraft
            modelBuilder.Entity<Aircraft>().HasData(
                new Aircraft {AircraftID = 1, AircraftName = "Boeing 737-800(738)", AircraftCapacity = 160, AircraftMaxFlyingDistance = 2835 },
                new Aircraft { AircraftID = 2, AircraftName = "Boeing 767-400 ER", AircraftCapacity = 246, AircraftMaxFlyingDistance = 6020 },
                new Aircraft { AircraftID = 3, AircraftName = "Boeing 747", AircraftCapacity = 539, AircraftMaxFlyingDistance = 6089 }
                );

            //Seed engineers, accountants, etc
            modelBuilder.Entity<Customer>().HasData(
                new Customer 
                    {
                        CustomerID = 1, 
                        CustomerAccountLevel = AccountLevel.ACCOUNTANT, 
                        CustomerUsername = "accountant", 
                        CustomerPassword = Hashing.ComputeHash("1234", Supported_HA.SHA512, null), 
                        CustomerAddress = "", 
                        CustomerAge = 0, 
                        CustomerCreditCardNumber = "", 
                        CustomerFirstName = "", 
                        CustomerLastName = "", 
                        CustomerPhoneNumber = "", 
                        CurrentPoints = 0
                    },
                new Customer
                    {
                        CustomerID = 2,
                        CustomerAccountLevel = AccountLevel.LOAD_ENGINEER,
                        CustomerUsername = "loadengineer",
                        CustomerPassword = Hashing.ComputeHash("1234", Supported_HA.SHA512, null),
                        CustomerAddress = "",
                        CustomerAge = 0,
                        CustomerCreditCardNumber = "",
                        CustomerFirstName = "",
                        CustomerLastName = "",
                        CustomerPhoneNumber = "",
                        CurrentPoints = 0
                    },
                new Customer
                    {
                        CustomerID = 3,
                        CustomerAccountLevel = AccountLevel.FLIGHT_MANAGER,
                        CustomerUsername = "flightmanager",
                        CustomerPassword = Hashing.ComputeHash("1234", Supported_HA.SHA512, null),
                        CustomerAddress = "",
                        CustomerAge = 0,
                        CustomerCreditCardNumber = "",
                        CustomerFirstName = "",
                        CustomerLastName = "",
                        CustomerPhoneNumber = "",
                        CurrentPoints = 0
                    },
                new Customer
                    {
                        CustomerID = 4,
                        CustomerAccountLevel = AccountLevel.MARKETING_MANAGER,
                        CustomerUsername = "marketingmanager",
                        CustomerPassword = Hashing.ComputeHash("1234", Supported_HA.SHA512, null),
                        CustomerAddress = "",
                        CustomerAge = 0,
                        CustomerCreditCardNumber = "",
                        CustomerFirstName = "",
                        CustomerLastName = "",
                        CustomerPhoneNumber = "",
                        CurrentPoints = 0
                    }
                );
            //Seed routes
            modelBuilder.Entity<Route>().HasData(               
                //Routes from Cleveland to Nashville
                new { RouteID = 1, RouteOriginCityCityID = 3, RouteOriginCityID = 3, RouteDestinationCityID = 2, RouteDestinationCityCityID = 2, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(6, 20, 0), isCanceled = false },
                new { RouteID = 2, RouteOriginCityCityID = 3, RouteOriginCityID = 3, RouteDestinationCityID = 2, RouteDestinationCityCityID = 2, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(10, 20, 0), isCanceled = false },
                new { RouteID = 3, RouteOriginCityCityID = 3, RouteOriginCityID = 3, RouteDestinationCityID = 2, RouteDestinationCityCityID = 2, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(14, 20, 0), isCanceled = false },
                new { RouteID = 4, RouteOriginCityCityID = 3, RouteOriginCityID = 3, RouteDestinationCityID = 2, RouteDestinationCityCityID = 2, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(18, 20, 0), isCanceled = false },
                //Routes from Nashville to Cleveland
                new { RouteID = 5, RouteOriginCityCityID = 2, RouteOriginCityID = 2, RouteDestinationCityID = 3, RouteDestinationCityCityID = 3, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(8, 20, 0), isCanceled = false },
                new { RouteID = 6, RouteOriginCityCityID = 2, RouteOriginCityID = 2, RouteDestinationCityID = 3, RouteDestinationCityCityID = 3, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(12, 20, 0), isCanceled = false },
                new { RouteID = 7, RouteOriginCityCityID = 2, RouteOriginCityID = 2, RouteDestinationCityID = 3, RouteDestinationCityCityID = 3, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(16, 20, 0), isCanceled = false },
                new { RouteID = 8, RouteOriginCityCityID = 2, RouteOriginCityID = 2, RouteDestinationCityID = 3, RouteDestinationCityCityID = 3, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(20, 20, 0), isCanceled = false },
                //Routes from Cleveland to Queens
                new { RouteID = 9, RouteOriginCityCityID = 3, RouteOriginCityID = 3, RouteDestinationCityID = 8, RouteDestinationCityCityID = 8, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(6, 40, 0), isCanceled = false },
                new { RouteID = 10, RouteOriginCityCityID = 3, RouteOriginCityID = 3, RouteDestinationCityID = 8, RouteDestinationCityCityID = 8, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(10, 40, 0), isCanceled = false },
                new { RouteID = 11, RouteOriginCityCityID = 3, RouteOriginCityID = 3, RouteDestinationCityID = 8, RouteDestinationCityCityID = 8, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(14, 40, 0), isCanceled = false },
                new { RouteID = 12, RouteOriginCityCityID = 3, RouteOriginCityID = 3, RouteDestinationCityID = 8, RouteDestinationCityCityID = 8, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(18, 40, 0), isCanceled = false },
                //Routes from Queens to Cleveland
                new { RouteID = 13, RouteOriginCityCityID = 8, RouteOriginCityID = 8, RouteDestinationCityID = 3, RouteDestinationCityCityID = 3, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(8, 40, 0), isCanceled = false },
                new { RouteID = 14, RouteOriginCityCityID = 8, RouteOriginCityID = 8, RouteDestinationCityID = 3, RouteDestinationCityCityID = 3, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(12, 40, 0), isCanceled = false },
                new { RouteID = 15, RouteOriginCityCityID = 8, RouteOriginCityID = 8, RouteDestinationCityID = 3, RouteDestinationCityCityID = 3, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(16, 40, 0), isCanceled = false },
                new { RouteID = 16, RouteOriginCityCityID = 8, RouteOriginCityID = 8, RouteDestinationCityID = 3, RouteDestinationCityCityID = 3, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(20, 40, 0), isCanceled = false },
                //Routes from Cleveland to Detroit
                new { RouteID = 17, RouteOriginCityCityID = 3, RouteOriginCityID = 3, RouteDestinationCityID = 6, RouteDestinationCityCityID = 6, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(7, 00, 0), isCanceled = false },
                new { RouteID = 18, RouteOriginCityCityID = 3, RouteOriginCityID = 3, RouteDestinationCityID = 6, RouteDestinationCityCityID = 6, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(11, 00, 0), isCanceled = false },
                new { RouteID = 19, RouteOriginCityCityID = 3, RouteOriginCityID = 3, RouteDestinationCityID = 6, RouteDestinationCityCityID = 6, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(15, 00, 0), isCanceled = false },
                new { RouteID = 20, RouteOriginCityCityID = 3, RouteOriginCityID = 3, RouteDestinationCityID = 6, RouteDestinationCityCityID = 6, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(19, 00, 0), isCanceled = false },
                //Routes from Detroit to Cleveland
                new { RouteID = 21, RouteOriginCityCityID = 6, RouteOriginCityID = 6, RouteDestinationCityID = 3, RouteDestinationCityCityID = 3, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(9, 00, 0), isCanceled = false },
                new { RouteID = 22, RouteOriginCityCityID = 6, RouteOriginCityID = 6, RouteDestinationCityID = 3, RouteDestinationCityCityID = 3, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(13, 00, 0), isCanceled = false },
                new { RouteID = 23, RouteOriginCityCityID = 6, RouteOriginCityID = 6, RouteDestinationCityID = 3, RouteDestinationCityCityID = 3, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(17, 00, 0), isCanceled = false },
                new { RouteID = 24, RouteOriginCityCityID = 6, RouteOriginCityID = 6, RouteDestinationCityID = 3, RouteDestinationCityCityID = 3, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(21, 00, 0), isCanceled = false },
                //Routes from Cleveland to Chicago
                new { RouteID = 25, RouteOriginCityCityID = 3, RouteOriginCityID = 3, RouteDestinationCityID = 10, RouteDestinationCityCityID = 10, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(5, 00, 0), isCanceled = false },
                new { RouteID = 26, RouteOriginCityCityID = 3, RouteOriginCityID = 3, RouteDestinationCityID = 10, RouteDestinationCityCityID = 10, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(9, 00, 0), isCanceled = false },
                new { RouteID = 27, RouteOriginCityCityID = 3, RouteOriginCityID = 3, RouteDestinationCityID = 10, RouteDestinationCityCityID = 10, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(13, 00, 0), isCanceled = false },
                new { RouteID = 28, RouteOriginCityCityID = 3, RouteOriginCityID = 3, RouteDestinationCityID = 10, RouteDestinationCityCityID = 10, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(17, 00, 0), isCanceled = false },
                //Routes from Chicago to Cleveland
                new { RouteID = 29, RouteOriginCityCityID = 10, RouteOriginCityID = 10, RouteDestinationCityID = 3, RouteDestinationCityCityID = 3, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(7, 00, 0), isCanceled = false },
                new { RouteID = 30, RouteOriginCityCityID = 10, RouteOriginCityID = 10, RouteDestinationCityID = 3, RouteDestinationCityCityID = 3, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(11, 00, 0), isCanceled = false },
                new { RouteID = 31, RouteOriginCityCityID = 10, RouteOriginCityID = 10, RouteDestinationCityID = 3, RouteDestinationCityCityID = 3, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(15, 00, 0), isCanceled = false },
                new { RouteID = 32, RouteOriginCityCityID = 10, RouteOriginCityID = 10, RouteDestinationCityID = 3, RouteDestinationCityCityID = 3, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(19, 00, 0), isCanceled = false },
                //Routes from Queens to Detroit
                new { RouteID = 33, RouteOriginCityCityID = 8, RouteOriginCityID = 8, RouteDestinationCityID = 6, RouteDestinationCityCityID = 6, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(4, 20, 0), isCanceled = false },
                new { RouteID = 34, RouteOriginCityCityID = 8, RouteOriginCityID = 8, RouteDestinationCityID = 6, RouteDestinationCityCityID = 6, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(8, 20, 0), isCanceled = false },
                new { RouteID = 35, RouteOriginCityCityID = 8, RouteOriginCityID = 8, RouteDestinationCityID = 6, RouteDestinationCityCityID = 6, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(12, 20, 0), isCanceled = false },
                new { RouteID = 36, RouteOriginCityCityID = 8, RouteOriginCityID = 8, RouteDestinationCityID = 6, RouteDestinationCityCityID = 6, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(16, 20, 0), isCanceled = false },
                //Routes from Detroit to Queens
                new { RouteID = 37, RouteOriginCityCityID = 6, RouteOriginCityID = 6, RouteDestinationCityID = 8, RouteDestinationCityCityID = 8, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(2, 20, 0), isCanceled = false },
                new { RouteID = 38, RouteOriginCityCityID = 6, RouteOriginCityID = 6, RouteDestinationCityID = 8, RouteDestinationCityCityID = 8, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(6, 20, 0), isCanceled = false },
                new { RouteID = 39, RouteOriginCityCityID = 6, RouteOriginCityID = 6, RouteDestinationCityID = 8, RouteDestinationCityCityID = 8, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(10, 20, 0), isCanceled = false },
                new { RouteID = 40, RouteOriginCityCityID = 6, RouteOriginCityID = 6, RouteDestinationCityID = 8, RouteDestinationCityCityID = 8, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(14, 20, 0), isCanceled = false },
                //Routes from Queens to Atlanta
                new { RouteID = 41, RouteOriginCityCityID = 8, RouteOriginCityID = 8, RouteDestinationCityID = 1, RouteDestinationCityCityID = 1, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(0, 20, 0), isCanceled = false },
                new { RouteID = 42, RouteOriginCityCityID = 8, RouteOriginCityID = 8, RouteDestinationCityID = 1, RouteDestinationCityCityID = 1, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(4, 20, 0), isCanceled = false },
                new { RouteID = 43, RouteOriginCityCityID = 8, RouteOriginCityID = 8, RouteDestinationCityID = 1, RouteDestinationCityCityID = 1, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(8, 20, 0), isCanceled = false },
                new { RouteID = 44, RouteOriginCityCityID = 8, RouteOriginCityID = 8, RouteDestinationCityID = 1, RouteDestinationCityCityID = 1, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(12, 20, 0), isCanceled = false },
                //Routes from Atlanta to Queens
                new { RouteID = 45, RouteOriginCityCityID = 1, RouteOriginCityID = 1, RouteDestinationCityID = 8, RouteDestinationCityCityID = 8, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(11, 20, 0), isCanceled = false },
                new { RouteID = 46, RouteOriginCityCityID = 1, RouteOriginCityID = 1, RouteDestinationCityID = 8, RouteDestinationCityCityID = 8, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(15, 20, 0), isCanceled = false },
                new { RouteID = 47, RouteOriginCityCityID = 1, RouteOriginCityID = 1, RouteDestinationCityID = 8, RouteDestinationCityCityID = 8, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(19, 20, 0), isCanceled = false },
                new { RouteID = 48, RouteOriginCityCityID = 1, RouteOriginCityID = 1, RouteDestinationCityID = 8, RouteDestinationCityCityID = 8, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(23, 20, 0), isCanceled = false },
                //Routes from Atlanta to Fort Lauderdale
                new { RouteID = 49, RouteOriginCityCityID = 1, RouteOriginCityID = 1, RouteDestinationCityID = 7, RouteDestinationCityCityID = 7, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(8, 15, 0), isCanceled = false },
                new { RouteID = 50, RouteOriginCityCityID = 1, RouteOriginCityID = 1, RouteDestinationCityID = 7, RouteDestinationCityCityID = 7, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(12, 15, 0), isCanceled = false },
                new { RouteID = 51, RouteOriginCityCityID = 1, RouteOriginCityID = 1, RouteDestinationCityID = 7, RouteDestinationCityCityID = 7, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(16, 15, 0), isCanceled = false },
                new { RouteID = 52, RouteOriginCityCityID = 1, RouteOriginCityID = 1, RouteDestinationCityID = 7, RouteDestinationCityCityID = 7, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(20, 15, 0), isCanceled = false },
                //Routes from Fort Lauderdale to Atlanta
                new { RouteID = 53, RouteOriginCityCityID = 7, RouteOriginCityID = 7, RouteDestinationCityID = 1, RouteDestinationCityCityID = 1, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(10, 15, 0), isCanceled = false },
                new { RouteID = 54, RouteOriginCityCityID = 7, RouteOriginCityID = 7, RouteDestinationCityID = 1, RouteDestinationCityCityID = 1, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(14, 15, 0), isCanceled = false },
                new { RouteID = 55, RouteOriginCityCityID = 7, RouteOriginCityID = 7, RouteDestinationCityID = 1, RouteDestinationCityCityID = 1, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(18, 15, 0), isCanceled = false },
                new { RouteID = 56, RouteOriginCityCityID = 7, RouteOriginCityID = 7, RouteDestinationCityID = 1, RouteDestinationCityCityID = 1, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(22, 15, 0), isCanceled = false },
                //Routes from Atlanta to Nashville
                new { RouteID = 57, RouteOriginCityCityID = 1, RouteOriginCityID = 1, RouteDestinationCityID = 2, RouteDestinationCityCityID = 2, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(4, 15, 0), isCanceled = false },
                new { RouteID = 58, RouteOriginCityCityID = 1, RouteOriginCityID = 1, RouteDestinationCityID = 2, RouteDestinationCityCityID = 2, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(8, 15, 0), isCanceled = false },
                new { RouteID = 59, RouteOriginCityCityID = 1, RouteOriginCityID = 1, RouteDestinationCityID = 2, RouteDestinationCityCityID = 2, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(12, 15, 0), isCanceled = false },
                new { RouteID = 60, RouteOriginCityCityID = 1, RouteOriginCityID = 1, RouteDestinationCityID = 2, RouteDestinationCityCityID = 2, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(16, 15, 0), isCanceled = false },
                //Routes from Nashville to Atlanta
                new { RouteID = 61, RouteOriginCityCityID = 2, RouteOriginCityID = 2, RouteDestinationCityID = 1, RouteDestinationCityCityID = 1, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(6, 15, 0), isCanceled = false },
                new { RouteID = 62, RouteOriginCityCityID = 2, RouteOriginCityID = 2, RouteDestinationCityID = 1, RouteDestinationCityCityID = 1, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(10, 15, 0), isCanceled = false },
                new { RouteID = 63, RouteOriginCityCityID = 2, RouteOriginCityID = 2, RouteDestinationCityID = 1, RouteDestinationCityCityID = 1, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(14, 15, 0), isCanceled = false },
                new { RouteID = 64, RouteOriginCityCityID = 2, RouteOriginCityID = 2, RouteDestinationCityID = 1, RouteDestinationCityCityID = 1, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(18, 15, 0), isCanceled = false },
                //Routes from Atlanta to Dallas
                new { RouteID = 65, RouteOriginCityCityID = 1, RouteOriginCityID = 1, RouteDestinationCityID = 5, RouteDestinationCityCityID = 5, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(4, 30, 0), isCanceled = false },
                new { RouteID = 66, RouteOriginCityCityID = 1, RouteOriginCityID = 1, RouteDestinationCityID = 5, RouteDestinationCityCityID = 5, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(8, 30, 0), isCanceled = false },
                new { RouteID = 67, RouteOriginCityCityID = 1, RouteOriginCityID = 1, RouteDestinationCityID = 5, RouteDestinationCityCityID = 5, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(12, 30, 0), isCanceled = false },
                new { RouteID = 68, RouteOriginCityCityID = 1, RouteOriginCityID = 1, RouteDestinationCityID = 5, RouteDestinationCityCityID = 5, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(16, 30, 0), isCanceled = false },
                //Routes from Dallas to Atlanta
                new { RouteID = 69, RouteOriginCityCityID = 5, RouteOriginCityID = 5, RouteDestinationCityID = 1, RouteDestinationCityCityID = 1, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(9, 30, 0), isCanceled = false },
                new { RouteID = 70, RouteOriginCityCityID = 5, RouteOriginCityID = 5, RouteDestinationCityID = 1, RouteDestinationCityCityID = 1, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(13, 30, 0), isCanceled = false },
                new { RouteID = 71, RouteOriginCityCityID = 5, RouteOriginCityID = 5, RouteDestinationCityID = 1, RouteDestinationCityCityID = 1, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(17, 30, 0), isCanceled = false },
                new { RouteID = 72, RouteOriginCityCityID = 5, RouteOriginCityID = 5, RouteDestinationCityID = 1, RouteDestinationCityCityID = 1, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(21, 30, 0), isCanceled = false },
                //Routes from Atlanta to Denver
                new { RouteID = 73, RouteOriginCityCityID = 1, RouteOriginCityID = 1, RouteDestinationCityID = 4, RouteDestinationCityCityID = 4, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(5, 30, 0), isCanceled = false },
                new { RouteID = 74, RouteOriginCityCityID = 1, RouteOriginCityID = 1, RouteDestinationCityID = 4, RouteDestinationCityCityID = 4, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(9, 30, 0), isCanceled = false },
                new { RouteID = 75, RouteOriginCityCityID = 1, RouteOriginCityID = 1, RouteDestinationCityID = 4, RouteDestinationCityCityID = 4, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(13, 30, 0), isCanceled = false },
                new { RouteID = 76, RouteOriginCityCityID = 1, RouteOriginCityID = 1, RouteDestinationCityID = 4, RouteDestinationCityCityID = 4, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(17, 30, 0), isCanceled = false },
                //Routes from Denver to Atlanta
                new { RouteID = 77, RouteOriginCityCityID = 4, RouteOriginCityID = 4, RouteDestinationCityID = 1, RouteDestinationCityCityID = 1, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(10, 30, 0), isCanceled = false },
                new { RouteID = 78, RouteOriginCityCityID = 4, RouteOriginCityID = 4, RouteDestinationCityID = 1, RouteDestinationCityCityID = 1, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(14, 30, 0), isCanceled = false },
                new { RouteID = 79, RouteOriginCityCityID = 4, RouteOriginCityID = 4, RouteDestinationCityID = 1, RouteDestinationCityCityID = 1, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(18, 30, 0), isCanceled = false },
                new { RouteID = 80, RouteOriginCityCityID = 4, RouteOriginCityID = 4, RouteDestinationCityID = 1, RouteDestinationCityCityID = 1, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(22, 30, 0), isCanceled = false },
                //Routes from Denver to Chicago
                new { RouteID = 81, RouteOriginCityCityID = 4, RouteOriginCityID = 4, RouteDestinationCityID = 10, RouteDestinationCityCityID = 10, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(11, 45, 0), isCanceled = false },
                new { RouteID = 82, RouteOriginCityCityID = 4, RouteOriginCityID = 4, RouteDestinationCityID = 10, RouteDestinationCityCityID = 10, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(15, 45, 0), isCanceled = false },
                new { RouteID = 83, RouteOriginCityCityID = 4, RouteOriginCityID = 4, RouteDestinationCityID = 10, RouteDestinationCityCityID = 10, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(19, 45, 0), isCanceled = false },
                new { RouteID = 84, RouteOriginCityCityID = 4, RouteOriginCityID = 4, RouteDestinationCityID = 10, RouteDestinationCityCityID = 10, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(23, 45, 0), isCanceled = false },
                //Routes from Chicago to Denver
                new { RouteID = 85, RouteOriginCityCityID = 10, RouteOriginCityID = 10, RouteDestinationCityID = 4, RouteDestinationCityCityID = 4, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(8, 45, 0), isCanceled = false },
                new { RouteID = 86, RouteOriginCityCityID = 10, RouteOriginCityID = 10, RouteDestinationCityID = 4, RouteDestinationCityCityID = 4, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(12, 45, 0), isCanceled = false },
                new { RouteID = 87, RouteOriginCityCityID = 10, RouteOriginCityID = 10, RouteDestinationCityID = 4, RouteDestinationCityCityID = 4, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(16, 45, 0), isCanceled = false },
                new { RouteID = 88, RouteOriginCityCityID = 10, RouteOriginCityID = 10, RouteDestinationCityID = 4, RouteDestinationCityCityID = 4, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(20, 45, 0), isCanceled = false },
                //Routes from Denver to Detroit
                new { RouteID = 89, RouteOriginCityCityID = 4, RouteOriginCityID = 4, RouteDestinationCityID = 6, RouteDestinationCityCityID = 6, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(2, 45, 0), isCanceled = false },
                new { RouteID = 90, RouteOriginCityCityID = 4, RouteOriginCityID = 4, RouteDestinationCityID = 6, RouteDestinationCityCityID = 6, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(6, 45, 0), isCanceled = false },
                new { RouteID = 91, RouteOriginCityCityID = 4, RouteOriginCityID = 4, RouteDestinationCityID = 6, RouteDestinationCityCityID = 6, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(10, 45, 0), isCanceled = false },
                new { RouteID = 92, RouteOriginCityCityID = 4, RouteOriginCityID = 4, RouteDestinationCityID = 6, RouteDestinationCityCityID = 6, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(14, 45, 0), isCanceled = false },
                //Routes from Detroit to Denver
                new { RouteID = 93, RouteOriginCityCityID = 6, RouteOriginCityID = 6, RouteDestinationCityID = 4, RouteDestinationCityCityID = 4, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(3, 45, 0), isCanceled = false },
                new { RouteID = 94, RouteOriginCityCityID = 6, RouteOriginCityID = 6, RouteDestinationCityID = 4, RouteDestinationCityCityID = 4, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(7, 45, 0), isCanceled = false },
                new { RouteID = 95, RouteOriginCityCityID = 6, RouteOriginCityID = 6, RouteDestinationCityID = 4, RouteDestinationCityCityID = 4, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(11, 45, 0), isCanceled = false },
                new { RouteID = 96, RouteOriginCityCityID = 6, RouteOriginCityID = 6, RouteDestinationCityID = 4, RouteDestinationCityCityID = 4, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(15, 45, 0), isCanceled = false },
                //Routes from Denver to Los Angeles
                new { RouteID = 97, RouteOriginCityCityID = 4, RouteOriginCityID = 4, RouteDestinationCityID = 9, RouteDestinationCityCityID = 9, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(0, 45, 0), isCanceled = false },
                new { RouteID = 98, RouteOriginCityCityID = 4, RouteOriginCityID = 4, RouteDestinationCityID = 9, RouteDestinationCityCityID = 9, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(4, 45, 0), isCanceled = false },
                new { RouteID = 99, RouteOriginCityCityID = 4, RouteOriginCityID = 4, RouteDestinationCityID = 9, RouteDestinationCityCityID = 9, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(8, 45, 0), isCanceled = false },
                new { RouteID = 100, RouteOriginCityCityID = 4, RouteOriginCityID = 4, RouteDestinationCityID = 9, RouteDestinationCityCityID = 9, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(12, 45, 0), isCanceled = false },
                //Routes from Los Angeles to Denver
                new { RouteID = 101, RouteOriginCityCityID = 9, RouteOriginCityID = 9, RouteDestinationCityID = 4, RouteDestinationCityCityID = 4, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(1, 45, 0), isCanceled = false },
                new { RouteID = 102, RouteOriginCityCityID = 9, RouteOriginCityID = 9, RouteDestinationCityID = 4, RouteDestinationCityCityID = 4, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(5, 45, 0), isCanceled = false },
                new { RouteID = 103, RouteOriginCityCityID = 9, RouteOriginCityID = 9, RouteDestinationCityID = 4, RouteDestinationCityCityID = 4, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(9, 45, 0), isCanceled = false },
                new { RouteID = 104, RouteOriginCityCityID = 9, RouteOriginCityID = 9, RouteDestinationCityID = 4, RouteDestinationCityCityID = 4, FlightAircraftAircraftID = 2, FlightDepartureTime = new TimeSpan(13, 45, 0), isCanceled = false },
                //Routes from Denver to Seattle
                new { RouteID = 105, RouteOriginCityCityID = 4, RouteOriginCityID = 4, RouteDestinationCityID = 11, RouteDestinationCityCityID = 11, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(4, 45, 0), isCanceled = false },
                new { RouteID = 106, RouteOriginCityCityID = 4, RouteOriginCityID = 4, RouteDestinationCityID = 11, RouteDestinationCityCityID = 11, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(8, 45, 0), isCanceled = false },
                new { RouteID = 107, RouteOriginCityCityID = 4, RouteOriginCityID = 4, RouteDestinationCityID = 11, RouteDestinationCityCityID = 11, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(12, 45, 0), isCanceled = false },
                new { RouteID = 108, RouteOriginCityCityID = 4, RouteOriginCityID = 4, RouteDestinationCityID = 11, RouteDestinationCityCityID = 11, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(16, 45, 0), isCanceled = false },
                //Routes from Seattle to Denver
                new { RouteID = 109, RouteOriginCityCityID = 11, RouteOriginCityID = 11, RouteDestinationCityID = 4, RouteDestinationCityCityID = 4, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(5, 45, 0), isCanceled = false },
                new { RouteID = 110, RouteOriginCityCityID = 11, RouteOriginCityID = 11, RouteDestinationCityID = 4, RouteDestinationCityCityID = 4, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(9, 45, 0), isCanceled = false },
                new { RouteID = 111, RouteOriginCityCityID = 11, RouteOriginCityID = 11, RouteDestinationCityID = 4, RouteDestinationCityCityID = 4, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(13, 45, 0), isCanceled = false },
                new { RouteID = 112, RouteOriginCityCityID = 11, RouteOriginCityID = 11, RouteDestinationCityID = 4, RouteDestinationCityCityID = 4, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(17, 45, 0), isCanceled = false },
                //Routes from Los Angeles to Dallas 
                new { RouteID = 113, RouteOriginCityCityID = 9, RouteOriginCityID = 9, RouteDestinationCityID = 5, RouteDestinationCityCityID = 5, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(10, 50, 0), isCanceled = false },
                new { RouteID = 114, RouteOriginCityCityID = 9, RouteOriginCityID = 9, RouteDestinationCityID = 5, RouteDestinationCityCityID = 5, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(14, 50, 0), isCanceled = false },
                new { RouteID = 115, RouteOriginCityCityID = 9, RouteOriginCityID = 9, RouteDestinationCityID = 5, RouteDestinationCityCityID = 5, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(18, 50, 0), isCanceled = false },
                new { RouteID = 116, RouteOriginCityCityID = 9, RouteOriginCityID = 9, RouteDestinationCityID = 5, RouteDestinationCityCityID = 5, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(22, 50, 0), isCanceled = false },
                //Routes from Dallas to Los Angeles
                new { RouteID = 117, RouteOriginCityCityID = 5, RouteOriginCityID = 5, RouteDestinationCityID = 9, RouteDestinationCityCityID = 9, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(11, 50, 0), isCanceled = false },
                new { RouteID = 118, RouteOriginCityCityID = 5, RouteOriginCityID = 5, RouteDestinationCityID = 9, RouteDestinationCityCityID = 9, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(15, 50, 0), isCanceled = false },
                new { RouteID = 119, RouteOriginCityCityID = 5, RouteOriginCityID = 5, RouteDestinationCityID = 9, RouteDestinationCityCityID = 9, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(19, 50, 0), isCanceled = false },
                new { RouteID = 120, RouteOriginCityCityID = 5, RouteOriginCityID = 5, RouteDestinationCityID = 9, RouteDestinationCityCityID = 9, FlightAircraftAircraftID = 3, FlightDepartureTime = new TimeSpan(23, 50, 0), isCanceled = false },
                //Routes from Chicago to Detroit
                new { RouteID = 121, RouteOriginCityCityID = 10, RouteOriginCityID = 10, RouteDestinationCityID = 6, RouteDestinationCityCityID = 6, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(8, 50, 0), isCanceled = false },
                new { RouteID = 122, RouteOriginCityCityID = 10, RouteOriginCityID = 10, RouteDestinationCityID = 6, RouteDestinationCityCityID = 6, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(12, 50, 0), isCanceled = false },
                new { RouteID = 123, RouteOriginCityCityID = 10, RouteOriginCityID = 10, RouteDestinationCityID = 6, RouteDestinationCityCityID = 6, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(16, 50, 0), isCanceled = false },
                new { RouteID = 124, RouteOriginCityCityID = 10, RouteOriginCityID = 10, RouteDestinationCityID = 6, RouteDestinationCityCityID = 6, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(20, 50, 0), isCanceled = false },
                //Routes from Detroit to Chicago
                new { RouteID = 125, RouteOriginCityCityID = 6, RouteOriginCityID = 6, RouteDestinationCityID = 10, RouteDestinationCityCityID = 10, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(9, 50, 0), isCanceled = false },
                new { RouteID = 126, RouteOriginCityCityID = 6, RouteOriginCityID = 6, RouteDestinationCityID = 10, RouteDestinationCityCityID = 10, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(13, 50, 0), isCanceled = false },
                new { RouteID = 127, RouteOriginCityCityID = 6, RouteOriginCityID = 6, RouteDestinationCityID = 10, RouteDestinationCityCityID = 10, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(17, 50, 0), isCanceled = false },
                new { RouteID = 128, RouteOriginCityCityID = 6, RouteOriginCityID = 6, RouteDestinationCityID = 10, RouteDestinationCityCityID = 10, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(21, 50, 0), isCanceled = false },
                //Routes from Chicago to Nashville
                new { RouteID = 129, RouteOriginCityCityID = 10, RouteOriginCityID = 10, RouteDestinationCityID = 2, RouteDestinationCityCityID = 2, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(8, 55, 0), isCanceled = false },
                new { RouteID = 130, RouteOriginCityCityID = 10, RouteOriginCityID = 10, RouteDestinationCityID = 2, RouteDestinationCityCityID = 2, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(12, 55, 0), isCanceled = false },
                new { RouteID = 131, RouteOriginCityCityID = 10, RouteOriginCityID = 10, RouteDestinationCityID = 2, RouteDestinationCityCityID = 2, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(16, 55, 0), isCanceled = false },
                new { RouteID = 132, RouteOriginCityCityID = 10, RouteOriginCityID = 10, RouteDestinationCityID = 2, RouteDestinationCityCityID = 2, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(20, 55, 0), isCanceled = false },
                //Routes from Nashville to Chicago
                new { RouteID = 133, RouteOriginCityCityID = 2, RouteOriginCityID = 2, RouteDestinationCityID = 10, RouteDestinationCityCityID = 10, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(9, 55, 0), isCanceled = false },
                new { RouteID = 134, RouteOriginCityCityID = 2, RouteOriginCityID = 2, RouteDestinationCityID = 10, RouteDestinationCityCityID = 10, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(13, 55, 0), isCanceled = false },
                new { RouteID = 135, RouteOriginCityCityID = 2, RouteOriginCityID = 2, RouteDestinationCityID = 10, RouteDestinationCityCityID = 10, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(17, 55, 0), isCanceled = false },
                new { RouteID = 136, RouteOriginCityCityID = 2, RouteOriginCityID = 2, RouteDestinationCityID = 10, RouteDestinationCityCityID = 10, FlightAircraftAircraftID = 1, FlightDepartureTime = new TimeSpan(21, 55, 0), isCanceled = false }
                ) ;
        }
    }
}
