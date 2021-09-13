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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air3550
{
    //This routepathing is a utility class that is a list of routes
    //It is used to store a route path constistin of legged flights if needed
    public class RoutePathing
    {
        public List<Route> Routes;

        public RoutePathing(params Route[] routes)
        {
            this.Routes = new(routes);
        }

        public int StopNumber => Routes.Count - 1;

        //get formatted time for departure
        public string getDepartureTimeFormatted()
        {
            return DateTime.Today.Add(Routes.First().FlightDepartureTime).ToString("h:mm tt");
        }
        //get formatted time for arrival
        public string getArrivalTimeFormatted()
        {
            return DateTime.Today.Add(Routes.Last().getArrivalTime()).ToString("h:mm tt");
        }

        //get duration of the entire routepath
        public string getDurationFormatted()
        {
            TimeSpan timeSpan = new TimeSpan();

            timeSpan += Routes[0].getDuration();

            //40 minute layover, have this in case route departs before previous route arrives plus 40
            //In that case add a day to the flight so it happens the next day and update routes
            TimeSpan layoverMinimum = new(0, 40, 0);

            for (int i = 1; i < Routes.Count; i++)
            {
                Route previousRoute = Routes[i - 1];
                Route route = Routes[i];

                if (route.FlightDepartureTime < previousRoute.getArrivalTime().Add(layoverMinimum))
                {
                    //Set flight to next day so layover minimum is reached and schedule is correct
                    //adding day
                    timeSpan = +new TimeSpan(1, 0, 0, 0);
                    //subtract previous flight arriving time from current flight departure time
                    timeSpan -= previousRoute.getArrivalTime() - route.FlightDepartureTime;
                }
                else 
                {
                    timeSpan += route.FlightDepartureTime - previousRoute.getArrivalTime();
                }

                timeSpan += route.getDuration();
            }

            //nice formatting
            string resultFormat = "";
            if (timeSpan.Days > 0)
            {
                resultFormat += timeSpan.Days + "d ";
            }
            if (timeSpan.Hours > 0)
            {
                resultFormat += timeSpan.Hours + "h ";
            }
            if (timeSpan.Minutes > 0)
            {
                resultFormat += timeSpan.Minutes + "m";
            }
            return resultFormat.Trim();
        }

        //check to see if a layover is good, between 40 minutes and 7 hours
        public bool isGoodLayover()
        {
            TimeSpan layoverMinimum = new(0, 40, 0);
            TimeSpan layoverMaximum = new(7, 0, 0);
            for (int i = 1; i < Routes.Count; i++)
            {
                Route previousRoute = Routes[i - 1];
                Route route = Routes[i];
                if ((route.FlightDepartureTime < previousRoute.getArrivalTime().Add(layoverMinimum)) || (route.FlightDepartureTime > previousRoute.getArrivalTime().Add(layoverMaximum)))
                {
                    return false;
                }
            }
            return true;
        }

        //This function checks all route flights and sees if there are tickets equal to the max capacity,
        ////if there are then the flight is full
        /////If the flight is full then it wont populate ticket
        public bool isFlightFull(DateTime departingDate, DateTime returnDate)
        {
            using (var db1 = new FlightContext())
            {
                foreach (Route route in Routes)
                {
                    //get flight associated with route on a particular date
                    //This checks to see if there is a flight for a route on either the departing date or return date
                    Flight departFlight = db1.Flights.Include(flight => flight.Tickets).SingleOrDefault(validFlight => (validFlight.FlightRouteID == route.RouteID && 
                    (validFlight.FlightDate.Date == departingDate.Date)));
                    Flight returnFlight = db1.Flights.Include(flight => flight.Tickets).SingleOrDefault(validFlight => (validFlight.FlightRouteID == route.RouteID &&
                    (validFlight.FlightDate.Date == returnDate.Date)));
                    int validTicketCount = 0;
                    int validTicketCountReturn = 0;

                    //get valid tickets
                    if (departFlight != null)
                    {
                        foreach (Ticket ticket in departFlight.Tickets)
                        {
                            if (ticket.IsCanceled)
                            {
                                continue;
                            }
                            validTicketCount++;
                        }

                        Route routeForFlight = db1.Routes.Include(routeAircraft => routeAircraft.FlightAircraft).Single(routeForFlight => routeForFlight.RouteID == route.RouteID);
                        //if routes capacity is equal to valid tickets, then return false and dont generate flight
                        if (routeForFlight.FlightAircraft.AircraftCapacity <= validTicketCount)
                        {
                            return true;
                        }
                    }

                    //get valid tickets
                    if (returnFlight != null)
                    {
                        foreach (Ticket ticket in returnFlight.Tickets)
                        {
                            if (ticket.IsCanceled)
                            {
                                continue;
                            }
                            validTicketCountReturn++;
                        }

                        Route routeForFlight = db1.Routes.Include(routeAircraft => routeAircraft.FlightAircraft).Single(routeForFlight => routeForFlight.RouteID == route.RouteID);
                        //if routes capacity is equal to valid tickets, then return false and dont generate flight
                        if (routeForFlight.FlightAircraft.AircraftCapacity <= validTicketCount)
                        {
                            return true;
                        }
                    }
                }

            }
                //flight has enough room for a booking, return false
                return false; 
        }

        //gets stops and displays them nicely formatted
        public string getStopsFormatted()
        {
            if (StopNumber == 0)
            {
                return "NonStop";
            }
            else if (StopNumber == 1)
            {
                return (StopNumber + " stop (" + Routes[0].RouteDestinationCity.CityNameCode + ")");
            }
            else
            {
                return (StopNumber + " stops (" + Routes[0].RouteDestinationCity.CityNameCode + ", " + Routes[1].RouteDestinationCity.CityNameCode + ") ");
            }
        }

        //price format
        public string getTotalPriceFormat()
        {
            return "$" + PriceCalculation.calcuateTotalPrice(Routes);
        }

        //price calculation
        public string getTotalPrice()
        {
            return PriceCalculation.calcuateTotalPrice(Routes).ToString();
        }
    }
}
