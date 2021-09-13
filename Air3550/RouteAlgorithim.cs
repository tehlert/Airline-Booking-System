/*
 Air 3550 Project Team 7

This program is a basic flight reservation system for a fake airline company
It allows customers to book, manage, cancel, and browse flights within a database.
It also allows employee accounts to update and manage flights and view business statistics.

Written by: Harrison Kania, Tyler Ehlert, Daniel Wellons
For EECS3550-001 Software Engineering, Instructor: Dr. Thomas 
 */
using Air3550.Database.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air3550
{
    class RouteAlgorithim
    {
        public static async Task<List<RoutePathing>> findRoutePaths(int departingAirportID, int destinationAirportID)
        {
            //This algorithim finds all route paths with 0, 1, or 2 connecting flights
            //This algorithim will return all route paths with the least amount of connections
            //This algorithim does not sort the routes in any order or the best route
            //It does return all paths with the least connections
            //The caller can sort these later for desired ticket generation

            using (var db = new FlightContext())
            {
                //Start by querying for direct routes
                var directRoutes = await db.Routes.Include(route => route.RouteOriginCity).Include(route => route.RouteDestinationCity)
                    .Where(route => !route.isCanceled && route.RouteOriginCityID == departingAirportID && route.RouteDestinationCityID == destinationAirportID).ToListAsync();

                //If there are direct routes then return them
                if (directRoutes.Count != 0)
                {
                    return directRoutes.Select(route => new RoutePathing(route)).ToList();
                }

                //Query to get all active routes in the database with their origin and destination airport
                var routes = db.Routes.Include(route => route.RouteOriginCity).Include(route => route.RouteDestinationCity)
                    .Where(route => !route.isCanceled);

                //Query for paths with one connecting flight
                var queryOneConnection = from route in routes //for each route not canceled
                                         //see if the origin city is the same as given at start
                                         where route.RouteOriginCityID == departingAirportID
                                         //join each connection where the destinationid equals the connections originid
                                         join connection in routes on route.RouteDestinationCityID equals connection.RouteOriginCityID
                                         //where the connections destination is equal to the arrival airport
                                         where connection.RouteDestinationCityID == destinationAirportID
                                         //make the route path with all the correct routes
                                         select new RoutePathing(route, connection);

                //Turn the query results into a list of possible routes
                var possibleRoutes = await queryOneConnection.ToListAsync();
                //Return them if there is at least one flight found
                if (possibleRoutes.Count != 0)
                {
                    return possibleRoutes;
                }

                //If we get here we have to get paths with two connecting flights
                var queryTwoConnections = from route in routes // for each route not canceled
                                                               //see if the origin city is the same as given at start
                                          where route.RouteOriginCityID == departingAirportID
                                          //join the first connection where origin city of the connecting route matches the first destination airport
                                          join firstConnection in routes on route.RouteDestinationCityID equals firstConnection.RouteOriginCityID
                                          //join the first connections destination airport when it equals the second connections origin
                                          join secondConnection in routes on firstConnection.RouteDestinationCityID equals secondConnection.RouteOriginCityID
                                          //finally, make sure the second connections destination is where we finally want to arrive
                                          where secondConnection.RouteDestinationCityID == destinationAirportID
                                          //make the route path with all the correct routes
                                          select new RoutePathing(route, firstConnection, secondConnection);
                //Return the list 
                return await queryTwoConnections.ToListAsync();
            }
        
        }
    }
}
