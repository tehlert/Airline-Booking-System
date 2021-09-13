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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air3550.Database.Models
{
    //This class is a utility class to calculate prices based on times of the routes
    class PriceCalculation
    {
        //Timespans for discounts
        static TimeSpan FiveAM = new TimeSpan(0, 5, 0, 0);
        static TimeSpan EightAM = new TimeSpan(0, 8, 0, 0);
        static TimeSpan SevenPM = new TimeSpan(0, 19, 0, 0);

        //This class compares to the departure time and arrival time of a route and then returns a value which is the discount
        public static decimal getDiscount(TimeSpan departureTime, TimeSpan arrivingTime)
        {
            TimeSpan arrivingTimeFormat = new TimeSpan(0, arrivingTime.Hours, arrivingTime.Minutes, arrivingTime.Seconds);
            if (arrivingTimeFormat > SevenPM || departureTime < EightAM)
            {
                return 0.10m;
            }
            else if ((departureTime < FiveAM) || (arrivingTime < FiveAM))
            {
                return 0.20m;
            }
            else 
            {
                return 0.00m;
            }
        }
        //This class calculates the total price of a route based on a list of routes in a path
        public static decimal calcuateTotalPrice(List<Route> routes)
        {
            if (routes.Count == 0)
            {
                return 0.0m;
            }
            //add in 50 base price * the discount
            decimal basePricing = 50 * (1m - getDiscount(routes.First().FlightDepartureTime, routes.Last().getArrivalTime()));
            decimal totalPrice = 0;
            totalPrice += basePricing;
            //increment total price based on route
            foreach (Route scheduledRoute in routes)
            {
                totalPrice += scheduledRoute.getPrice();
            }
            //add in $8 for each leg and return
            totalPrice += (8 *(routes.Count - 1));
            return totalPrice;      
        }


    }
}
