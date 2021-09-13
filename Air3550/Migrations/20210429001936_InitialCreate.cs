using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Air3550.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aircrafts",
                columns: table => new
                {
                    AircraftID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AircraftName = table.Column<string>(type: "TEXT", nullable: false),
                    AircraftCapacity = table.Column<int>(type: "INTEGER", nullable: false),
                    AircraftMaxFlyingDistance = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircrafts", x => x.AircraftID);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CityNameCode = table.Column<string>(type: "TEXT", nullable: false),
                    CityName = table.Column<string>(type: "TEXT", nullable: false),
                    CityLatitude = table.Column<decimal>(type: "Decimal(8,6)", nullable: false),
                    CityLongitude = table.Column<decimal>(type: "Decimal(9,6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerAccountLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    CustomerUsername = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerPassword = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerFirstName = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerLastName = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerAddress = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerPhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerAge = table.Column<int>(type: "INTEGER", nullable: false),
                    CustomerCreditCardNumber = table.Column<string>(type: "TEXT", nullable: false),
                    CurrentPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    UsedPoints = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    RouteID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RouteOriginCityID = table.Column<int>(type: "INTEGER", nullable: false),
                    RouteDestinationCityID = table.Column<int>(type: "INTEGER", nullable: false),
                    FlightAircraftAircraftID = table.Column<int>(type: "INTEGER", nullable: true),
                    FlightDepartureTime = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    isCanceled = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.RouteID);
                    table.ForeignKey(
                        name: "FK_Routes_Aircrafts_FlightAircraftAircraftID",
                        column: x => x.FlightAircraftAircraftID,
                        principalTable: "Aircrafts",
                        principalColumn: "AircraftID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Routes_Cities_RouteDestinationCityID",
                        column: x => x.RouteDestinationCityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Routes_Cities_RouteOriginCityID",
                        column: x => x.RouteOriginCityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TransactionBookingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TransactionDepartureDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TransactionCustomerID = table.Column<int>(type: "INTEGER", nullable: false),
                    TransactionType = table.Column<string>(type: "TEXT", nullable: false),
                    TransactionTotalPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    TransactionBillingType = table.Column<string>(type: "TEXT", nullable: false),
                    PointsClaimed = table.Column<bool>(type: "INTEGER", nullable: false),
                    isCanceled = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_Transactions_Customers_TransactionCustomerID",
                        column: x => x.TransactionCustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    FlightID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FlightDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FlightRouteID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FlightID);
                    table.ForeignKey(
                        name: "FK_Flights_Routes_FlightRouteID",
                        column: x => x.FlightRouteID,
                        principalTable: "Routes",
                        principalColumn: "RouteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FlightID = table.Column<int>(type: "INTEGER", nullable: false),
                    TransactionID = table.Column<int>(type: "INTEGER", nullable: false),
                    IsCanceled = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Ticket_Flights_FlightID",
                        column: x => x.FlightID,
                        principalTable: "Flights",
                        principalColumn: "FlightID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Transactions_TransactionID",
                        column: x => x.TransactionID,
                        principalTable: "Transactions",
                        principalColumn: "TransactionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "AircraftID", "AircraftCapacity", "AircraftMaxFlyingDistance", "AircraftName" },
                values: new object[] { 1, 160, 2835, "Boeing 737-800(738)" });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "AircraftID", "AircraftCapacity", "AircraftMaxFlyingDistance", "AircraftName" },
                values: new object[] { 2, 246, 6020, "Boeing 767-400 ER" });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "AircraftID", "AircraftCapacity", "AircraftMaxFlyingDistance", "AircraftName" },
                values: new object[] { 3, 539, 6089, "Boeing 747" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityLatitude", "CityLongitude", "CityName", "CityNameCode" },
                values: new object[] { 11, 47.448889m, -122.309444m, "Seattle", "SEA" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityLatitude", "CityLongitude", "CityName", "CityNameCode" },
                values: new object[] { 10, 41.978611m, -87.904722m, "Chicago", "ORD" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityLatitude", "CityLongitude", "CityName", "CityNameCode" },
                values: new object[] { 9, 33.9425m, -118.408056m, "Los Angeles", "LAX" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityLatitude", "CityLongitude", "CityName", "CityNameCode" },
                values: new object[] { 8, 40.775m, -73.875m, "Queens", "LGA" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityLatitude", "CityLongitude", "CityName", "CityNameCode" },
                values: new object[] { 7, 26.0725m, -80.152778m, "Fort Lauderdale", "FLL" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityLatitude", "CityLongitude", "CityName", "CityNameCode" },
                values: new object[] { 6, 42.2125m, -83.353333m, "Detroit", "DTW" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityLatitude", "CityLongitude", "CityName", "CityNameCode" },
                values: new object[] { 5, 32.896944m, -97.038056m, "Dallas", "DFW" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityLatitude", "CityLongitude", "CityName", "CityNameCode" },
                values: new object[] { 4, 39.861667m, -104.673056m, "Denver", "DEN" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityLatitude", "CityLongitude", "CityName", "CityNameCode" },
                values: new object[] { 3, 41.411667m, -81.849722m, "Cleveland", "CLE" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityLatitude", "CityLongitude", "CityName", "CityNameCode" },
                values: new object[] { 2, 36.126667m, -86.681944m, "Nashville", "BNA" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityLatitude", "CityLongitude", "CityName", "CityNameCode" },
                values: new object[] { 1, 33.636667m, -84.428056m, "Atlanta", "ATL" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "CurrentPoints", "CustomerAccountLevel", "CustomerAddress", "CustomerAge", "CustomerCreditCardNumber", "CustomerFirstName", "CustomerLastName", "CustomerPassword", "CustomerPhoneNumber", "CustomerUsername", "UsedPoints" },
                values: new object[] { 1, 0, 1, "", 0, "", "", "", "CkUr/9qzo+RG6KmxbOG4pmhSdZj28kLqQWfMVVCev214e/xDfHkHECGnqdLoeruRdT01jlPqAsAQoa79RyFg2iocTW//", "", "accountant", 0 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "CurrentPoints", "CustomerAccountLevel", "CustomerAddress", "CustomerAge", "CustomerCreditCardNumber", "CustomerFirstName", "CustomerLastName", "CustomerPassword", "CustomerPhoneNumber", "CustomerUsername", "UsedPoints" },
                values: new object[] { 2, 0, 2, "", 0, "", "", "", "kPENY3iPYXZ8NHy73Xb9dvsqr6ulVn+aOWiBO8HPGvde5FZj/RmrV6sHXG6D+7yH1bpGLK+Zf4pKTqSlDyoPE6pJwiAUeDNsRw==", "", "loadengineer", 0 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "CurrentPoints", "CustomerAccountLevel", "CustomerAddress", "CustomerAge", "CustomerCreditCardNumber", "CustomerFirstName", "CustomerLastName", "CustomerPassword", "CustomerPhoneNumber", "CustomerUsername", "UsedPoints" },
                values: new object[] { 3, 0, 4, "", 0, "", "", "", "PQ86GB9720AOnAvx/EptQ1umzC6InrghCtTmc2iwXP/iIpYuASVBrWvr/o8h1SfZXtpZUmk2orsmhlZCqat6btMkH8b2Hnb4/e4u", "", "flightmanager", 0 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "CurrentPoints", "CustomerAccountLevel", "CustomerAddress", "CustomerAge", "CustomerCreditCardNumber", "CustomerFirstName", "CustomerLastName", "CustomerPassword", "CustomerPhoneNumber", "CustomerUsername", "UsedPoints" },
                values: new object[] { 4, 0, 3, "", 0, "", "", "", "/ye1E/NpN0Y5FABSBdZDn2BxINlXBoeRj7vHCybDM46Gm9RHrjC2KpawIs8/ABDw1njYj1NAPf9mkczoJYchsDdTxmpPh6/WWwOb/g==", "", "marketingmanager", 0 });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 57, 1, new TimeSpan(0, 4, 15, 0, 0), 2, 1, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 28, 1, new TimeSpan(0, 17, 0, 0, 0), 10, 3, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 27, 1, new TimeSpan(0, 13, 0, 0, 0), 10, 3, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 26, 1, new TimeSpan(0, 9, 0, 0, 0), 10, 3, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 25, 1, new TimeSpan(0, 5, 0, 0, 0), 10, 3, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 120, 3, new TimeSpan(0, 23, 50, 0, 0), 9, 5, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 119, 3, new TimeSpan(0, 19, 50, 0, 0), 9, 5, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 118, 3, new TimeSpan(0, 15, 50, 0, 0), 9, 5, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 117, 3, new TimeSpan(0, 11, 50, 0, 0), 9, 5, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 116, 3, new TimeSpan(0, 22, 50, 0, 0), 5, 9, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 115, 3, new TimeSpan(0, 18, 50, 0, 0), 5, 9, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 114, 3, new TimeSpan(0, 14, 50, 0, 0), 5, 9, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 113, 3, new TimeSpan(0, 10, 50, 0, 0), 5, 9, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 104, 2, new TimeSpan(0, 13, 45, 0, 0), 4, 9, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 103, 2, new TimeSpan(0, 9, 45, 0, 0), 4, 9, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 29, 1, new TimeSpan(0, 7, 0, 0, 0), 3, 10, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 102, 2, new TimeSpan(0, 5, 45, 0, 0), 4, 9, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 100, 2, new TimeSpan(0, 12, 45, 0, 0), 9, 4, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 99, 2, new TimeSpan(0, 8, 45, 0, 0), 9, 4, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 98, 2, new TimeSpan(0, 4, 45, 0, 0), 9, 4, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 97, 2, new TimeSpan(0, 0, 45, 0, 0), 9, 4, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 48, 2, new TimeSpan(0, 23, 20, 0, 0), 8, 1, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 47, 2, new TimeSpan(0, 19, 20, 0, 0), 8, 1, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 46, 2, new TimeSpan(0, 15, 20, 0, 0), 8, 1, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 45, 2, new TimeSpan(0, 11, 20, 0, 0), 8, 1, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 44, 2, new TimeSpan(0, 12, 20, 0, 0), 1, 8, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 43, 2, new TimeSpan(0, 8, 20, 0, 0), 1, 8, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 42, 2, new TimeSpan(0, 4, 20, 0, 0), 1, 8, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 41, 2, new TimeSpan(0, 0, 20, 0, 0), 1, 8, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 40, 1, new TimeSpan(0, 14, 20, 0, 0), 8, 6, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 39, 1, new TimeSpan(0, 10, 20, 0, 0), 8, 6, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 101, 2, new TimeSpan(0, 1, 45, 0, 0), 4, 9, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 38, 1, new TimeSpan(0, 6, 20, 0, 0), 8, 6, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 30, 1, new TimeSpan(0, 11, 0, 0, 0), 3, 10, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 32, 1, new TimeSpan(0, 19, 0, 0, 0), 3, 10, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 110, 3, new TimeSpan(0, 9, 45, 0, 0), 4, 11, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 109, 3, new TimeSpan(0, 5, 45, 0, 0), 4, 11, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 108, 3, new TimeSpan(0, 16, 45, 0, 0), 11, 4, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 107, 3, new TimeSpan(0, 12, 45, 0, 0), 11, 4, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 106, 3, new TimeSpan(0, 8, 45, 0, 0), 11, 4, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 105, 3, new TimeSpan(0, 4, 45, 0, 0), 11, 4, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 136, 1, new TimeSpan(0, 21, 55, 0, 0), 10, 2, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 135, 1, new TimeSpan(0, 17, 55, 0, 0), 10, 2, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 134, 1, new TimeSpan(0, 13, 55, 0, 0), 10, 2, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 133, 1, new TimeSpan(0, 9, 55, 0, 0), 10, 2, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 132, 1, new TimeSpan(0, 20, 55, 0, 0), 2, 10, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 131, 1, new TimeSpan(0, 16, 55, 0, 0), 2, 10, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 130, 1, new TimeSpan(0, 12, 55, 0, 0), 2, 10, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 129, 1, new TimeSpan(0, 8, 55, 0, 0), 2, 10, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 31, 1, new TimeSpan(0, 15, 0, 0, 0), 3, 10, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 128, 1, new TimeSpan(0, 21, 50, 0, 0), 10, 6, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 126, 1, new TimeSpan(0, 13, 50, 0, 0), 10, 6, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 125, 1, new TimeSpan(0, 9, 50, 0, 0), 10, 6, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 124, 1, new TimeSpan(0, 20, 50, 0, 0), 6, 10, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 123, 1, new TimeSpan(0, 16, 50, 0, 0), 6, 10, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 122, 1, new TimeSpan(0, 12, 50, 0, 0), 6, 10, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 121, 1, new TimeSpan(0, 8, 50, 0, 0), 6, 10, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 88, 2, new TimeSpan(0, 20, 45, 0, 0), 4, 10, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 87, 2, new TimeSpan(0, 16, 45, 0, 0), 4, 10, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 86, 2, new TimeSpan(0, 12, 45, 0, 0), 4, 10, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 85, 2, new TimeSpan(0, 8, 45, 0, 0), 4, 10, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 84, 2, new TimeSpan(0, 23, 45, 0, 0), 10, 4, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 83, 2, new TimeSpan(0, 19, 45, 0, 0), 10, 4, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 82, 2, new TimeSpan(0, 15, 45, 0, 0), 10, 4, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 81, 2, new TimeSpan(0, 11, 45, 0, 0), 10, 4, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 127, 1, new TimeSpan(0, 17, 50, 0, 0), 10, 6, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 37, 1, new TimeSpan(0, 2, 20, 0, 0), 8, 6, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 36, 1, new TimeSpan(0, 16, 20, 0, 0), 6, 8, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 35, 1, new TimeSpan(0, 12, 20, 0, 0), 6, 8, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 71, 2, new TimeSpan(0, 17, 30, 0, 0), 1, 5, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 70, 2, new TimeSpan(0, 13, 30, 0, 0), 1, 5, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 69, 2, new TimeSpan(0, 9, 30, 0, 0), 1, 5, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 68, 2, new TimeSpan(0, 16, 30, 0, 0), 5, 1, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 67, 2, new TimeSpan(0, 12, 30, 0, 0), 5, 1, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 66, 2, new TimeSpan(0, 8, 30, 0, 0), 5, 1, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 65, 2, new TimeSpan(0, 4, 30, 0, 0), 5, 1, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 80, 3, new TimeSpan(0, 22, 30, 0, 0), 1, 4, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 79, 3, new TimeSpan(0, 18, 30, 0, 0), 1, 4, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 78, 3, new TimeSpan(0, 14, 30, 0, 0), 1, 4, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 77, 3, new TimeSpan(0, 10, 30, 0, 0), 1, 4, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 76, 3, new TimeSpan(0, 17, 30, 0, 0), 4, 1, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 75, 3, new TimeSpan(0, 13, 30, 0, 0), 4, 1, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 74, 3, new TimeSpan(0, 9, 30, 0, 0), 4, 1, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 72, 2, new TimeSpan(0, 21, 30, 0, 0), 1, 5, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 73, 3, new TimeSpan(0, 5, 30, 0, 0), 4, 1, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 7, 1, new TimeSpan(0, 16, 20, 0, 0), 3, 2, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 6, 1, new TimeSpan(0, 12, 20, 0, 0), 3, 2, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 5, 1, new TimeSpan(0, 8, 20, 0, 0), 3, 2, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 4, 1, new TimeSpan(0, 18, 20, 0, 0), 2, 3, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 3, 1, new TimeSpan(0, 14, 20, 0, 0), 2, 3, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 2, 1, new TimeSpan(0, 10, 20, 0, 0), 2, 3, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 1, 1, new TimeSpan(0, 6, 20, 0, 0), 2, 3, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 64, 1, new TimeSpan(0, 18, 15, 0, 0), 1, 2, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 63, 1, new TimeSpan(0, 14, 15, 0, 0), 1, 2, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 62, 1, new TimeSpan(0, 10, 15, 0, 0), 1, 2, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 61, 1, new TimeSpan(0, 6, 15, 0, 0), 1, 2, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 60, 1, new TimeSpan(0, 16, 15, 0, 0), 2, 1, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 59, 1, new TimeSpan(0, 12, 15, 0, 0), 2, 1, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 58, 1, new TimeSpan(0, 8, 15, 0, 0), 2, 1, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 8, 1, new TimeSpan(0, 20, 20, 0, 0), 3, 2, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 17, 1, new TimeSpan(0, 7, 0, 0, 0), 6, 3, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 18, 1, new TimeSpan(0, 11, 0, 0, 0), 6, 3, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 19, 1, new TimeSpan(0, 15, 0, 0, 0), 6, 3, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 34, 1, new TimeSpan(0, 8, 20, 0, 0), 6, 8, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 33, 1, new TimeSpan(0, 4, 20, 0, 0), 6, 8, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 16, 1, new TimeSpan(0, 20, 40, 0, 0), 3, 8, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 15, 1, new TimeSpan(0, 16, 40, 0, 0), 3, 8, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 14, 1, new TimeSpan(0, 12, 40, 0, 0), 3, 8, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 13, 1, new TimeSpan(0, 8, 40, 0, 0), 3, 8, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 12, 1, new TimeSpan(0, 18, 40, 0, 0), 8, 3, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 11, 1, new TimeSpan(0, 14, 40, 0, 0), 8, 3, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 10, 1, new TimeSpan(0, 10, 40, 0, 0), 8, 3, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 9, 1, new TimeSpan(0, 6, 40, 0, 0), 8, 3, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 56, 1, new TimeSpan(0, 22, 15, 0, 0), 1, 7, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 55, 1, new TimeSpan(0, 18, 15, 0, 0), 1, 7, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 54, 1, new TimeSpan(0, 14, 15, 0, 0), 1, 7, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 53, 1, new TimeSpan(0, 10, 15, 0, 0), 1, 7, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 52, 1, new TimeSpan(0, 20, 15, 0, 0), 7, 1, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 51, 1, new TimeSpan(0, 16, 15, 0, 0), 7, 1, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 50, 1, new TimeSpan(0, 12, 15, 0, 0), 7, 1, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 20, 1, new TimeSpan(0, 19, 0, 0, 0), 6, 3, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 21, 1, new TimeSpan(0, 9, 0, 0, 0), 3, 6, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 22, 1, new TimeSpan(0, 13, 0, 0, 0), 3, 6, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 23, 1, new TimeSpan(0, 17, 0, 0, 0), 3, 6, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 24, 1, new TimeSpan(0, 21, 0, 0, 0), 3, 6, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 89, 3, new TimeSpan(0, 2, 45, 0, 0), 6, 4, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 111, 3, new TimeSpan(0, 13, 45, 0, 0), 4, 11, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 90, 3, new TimeSpan(0, 6, 45, 0, 0), 6, 4, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 92, 3, new TimeSpan(0, 14, 45, 0, 0), 6, 4, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 93, 3, new TimeSpan(0, 3, 45, 0, 0), 4, 6, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 94, 3, new TimeSpan(0, 7, 45, 0, 0), 4, 6, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 95, 3, new TimeSpan(0, 11, 45, 0, 0), 4, 6, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 96, 3, new TimeSpan(0, 15, 45, 0, 0), 4, 6, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 49, 1, new TimeSpan(0, 8, 15, 0, 0), 7, 1, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 91, 3, new TimeSpan(0, 10, 45, 0, 0), 6, 4, false });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteID", "FlightAircraftAircraftID", "FlightDepartureTime", "RouteDestinationCityID", "RouteOriginCityID", "isCanceled" },
                values: new object[] { 112, 3, new TimeSpan(0, 17, 45, 0, 0), 4, 11, false });

            migrationBuilder.CreateIndex(
                name: "IX_Flights_FlightRouteID",
                table: "Flights",
                column: "FlightRouteID");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_FlightAircraftAircraftID",
                table: "Routes",
                column: "FlightAircraftAircraftID");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_RouteDestinationCityID",
                table: "Routes",
                column: "RouteDestinationCityID");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_RouteOriginCityID",
                table: "Routes",
                column: "RouteOriginCityID");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_FlightID",
                table: "Ticket",
                column: "FlightID");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TransactionID",
                table: "Ticket",
                column: "TransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_TransactionCustomerID",
                table: "Transactions",
                column: "TransactionCustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Aircrafts");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
