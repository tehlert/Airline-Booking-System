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
    //Database Model for the route , include the id, origin city, destination city, aircraft. and departure time
    public class Route
    {
        public int RouteID { get; set; }
        
        public int RouteOriginCityID { get; set; }
        [Required]
        public City RouteOriginCity { get; set; }

        public int RouteDestinationCityID { get; set; }
        [Required]
        public City RouteDestinationCity { get; set; }
        [Required]
        public Aircraft FlightAircraft { get; set; }
        [Required]
        public TimeSpan FlightDepartureTime { get; set; }
        //this is added for if the route engineer cancels the route, it sets the flag if they do
        //Route is not deleted from DB to avoid complications
        public bool isCanceled { get; set; }
        //This function gets the distance between the routes cities
        public double getDistance()
        {
            static double toRadians(decimal angdeg)
            {
                return Math.PI * (double)angdeg / 180.0;
            }
            double rlat1 = toRadians(RouteDestinationCity.CityLatitude);
            double rlat2 = toRadians(RouteOriginCity.CityLatitude);
            double theta = (double)RouteDestinationCity.CityLongitude - (double)RouteOriginCity.CityLongitude;
            double rtheta = Math.PI * theta / 180;
            double dist =
                Math.Sin(rlat1) * Math.Sin(rlat2) + Math.Cos(rlat1) *
                Math.Cos(rlat2) * Math.Cos(rtheta);
            dist = Math.Acos(dist);
            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;

            return Math.Round(dist);
        }
        //This function gets the duration of the entire route
        public TimeSpan getDuration()
        {
            // 30 minutes in flat time
            double duration = 30.0 + getDistance() * (60.0/500.0);
            int hours = (int)duration / 60;
            int minutes = (int)duration % 60;
            return new(hours, minutes, 0);
        }
        //This function gets the arrival time based off the departing time and using the duration function
        public TimeSpan getArrivalTime()
        {
            TimeSpan arrivingTime = FlightDepartureTime;
            TimeSpan duration = getDuration();
            arrivingTime = arrivingTime.Add(duration);
            return arrivingTime;
        }
        //This function gets the price of the route doing distance *.12 per mile
         public decimal getPrice()
        {
            decimal routePrice = 0;
            double duration = getDistance();
            routePrice += Convert.ToDecimal(duration) * 0.12m;

            routePrice *= 1m - PriceCalculation.getDiscount(FlightDepartureTime, getArrivalTime());

            return Math.Truncate(100 * routePrice) / 100;

        }
        //basic constructor
        public Route()
        {

        }
    }
}
