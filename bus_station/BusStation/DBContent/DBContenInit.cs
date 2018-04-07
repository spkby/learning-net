using BusStation.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace BusStation.DBContext
{
    public class DBContenUserInit : DropCreateDatabaseIfModelChanges<DBContent>
    {
        protected override void Seed(DBContent context)
        {
            var roles = new List<Role>
            {
                new Role{ RoleId = 1, RoleName = "Admin"},
                new Role{ RoleId = 2, RoleName = "Сashier"},
                new Role{ RoleId = 3, RoleName = "Guest"}
            };

            roles.ForEach(r => context.Roles.Add(r));
            //context.SaveChanges();

            var users = new List<User>
            {
                new User { UserID = 1, Name = "Admin", Password = "123456", PasswordCnfm = "123456", Email = "admin@com.com", RoleId = 1 },
                new User { UserID = 2, Name = "Guest", Password = "123456", PasswordCnfm = "123456", Email = "guest@com.com", RoleId = 3 },
                new User { UserID = 3, Name = "Сashier 1", Password = "123456", PasswordCnfm = "123456", Email = "Сashier1@com.com", RoleId = 2 },
                new User { UserID = 4, Name = "Сashier 2", Password = "123456", PasswordCnfm = "123456", Email = "Сashier2@com.com", RoleId = 2 },
                new User { UserID = 5, Name = "Сashier 3", Password = "123456", PasswordCnfm = "123456", Email = "Сashier3@com.com", RoleId = 2 }
            };

            users.ForEach(u => context.Users.Add(u));
            //context.SaveChanges();

            var cities = new List<City>
            {
                new City {CityId = 1, CityName = "Брест"},
                new City {CityId = 2, CityName = "Витебск"},
                new City {CityId = 3, CityName = "Гомель"},
                new City {CityId = 4, CityName = "Гродно"},
                new City {CityId = 5, CityName = "Минск"},
                new City {CityId = 6, CityName = "Могилев"}
            };
            cities.ForEach(u => context.Cities.Add(u));
            //context.SaveChanges();

            var buses = new List<Bus>
            {
                new Bus {BusId = 1, Number="AA 0001 3", Seats=40, Coefficient=1},
                new Bus {BusId = 2, Number="AA 0002 3", Seats=30, Coefficient=2},
                new Bus {BusId = 3, Number="AA 0003 3", Seats=20, Coefficient=2}
            };
            buses.ForEach(u => context.Buses.Add(u));
            //context.SaveChanges();

            var prices = new List<Price>
            {
                new Price { PriceId=1, PricePerKM=10,DatePrice = Convert.ToDateTime("2018-01-01 00:00:00")},
                new Price { PriceId=2, PricePerKM=15,DatePrice = Convert.ToDateTime("2018-03-01 00:00:00")}
            };

            prices.ForEach(m => context.Prices.Add(m));
            //context.SaveChanges();

            var routes = new List<Route>
            {
                new Route { RouteId=1,CityIdFrom=1,CityIdTo=5,Distance=320},
                new Route { RouteId=2,CityIdFrom=5,CityIdTo=1,Distance=320},
                new Route { RouteId=3,CityIdFrom=1,CityIdTo=2,Distance=520},
                new Route { RouteId=4,CityIdFrom=2,CityIdTo=1,Distance=520}
            };

            routes.ForEach(m => context.Routes.Add(m));
            //context.SaveChanges();

            var trips = new List<Trip>
            {
                new Trip { BusId=1, RouteId=1, Date=Convert.ToDateTime("2018-04-01 07:00:00")},
                new Trip { BusId=2, RouteId=2, Date=Convert.ToDateTime("2018-04-01 07:00:00")},
                new Trip { BusId=2, RouteId=1, Date=Convert.ToDateTime("2018-04-01 14:00:00")},
                new Trip { BusId=3, RouteId=2, Date=Convert.ToDateTime("2018-04-01 14:00:00")},
                new Trip { BusId=3, RouteId=1, Date=Convert.ToDateTime("2018-04-01 21:00:00")},
                new Trip { BusId=1, RouteId=2, Date=Convert.ToDateTime("2018-04-01 21:00:00")},

                new Trip { BusId=1, RouteId=1, Date=Convert.ToDateTime("2018-04-02 07:00:00")},
                new Trip { BusId=2, RouteId=2, Date=Convert.ToDateTime("2018-04-02 07:00:00")},
                new Trip { BusId=2, RouteId=1, Date=Convert.ToDateTime("2018-04-02 14:00:00")},
                new Trip { BusId=3, RouteId=2, Date=Convert.ToDateTime("2018-04-02 14:00:00")},
                new Trip { BusId=3, RouteId=1, Date=Convert.ToDateTime("2018-04-02 21:00:00")},
                new Trip { BusId=1, RouteId=2, Date=Convert.ToDateTime("2018-04-02 21:00:00")},

                new Trip { BusId=1, RouteId=1, Date=Convert.ToDateTime("2018-04-03 07:00:00")},
                new Trip { BusId=2, RouteId=2, Date=Convert.ToDateTime("2018-04-03 07:00:00")},
                new Trip { BusId=2, RouteId=1, Date=Convert.ToDateTime("2018-04-03 14:00:00")},
                new Trip { BusId=3, RouteId=2, Date=Convert.ToDateTime("2018-04-03 14:00:00")},
                new Trip { BusId=3, RouteId=1, Date=Convert.ToDateTime("2018-04-03 21:00:00")},
                new Trip { BusId=1, RouteId=2, Date=Convert.ToDateTime("2018-04-03 21:00:00")},

                new Trip { BusId=1, RouteId=1, Date=Convert.ToDateTime("2018-04-04 07:00:00")},
                new Trip { BusId=2, RouteId=2, Date=Convert.ToDateTime("2018-04-04 07:00:00")},
                new Trip { BusId=2, RouteId=1, Date=Convert.ToDateTime("2018-04-04 14:00:00")},
                new Trip { BusId=3, RouteId=2, Date=Convert.ToDateTime("2018-04-04 14:00:00")},
                new Trip { BusId=3, RouteId=1, Date=Convert.ToDateTime("2018-04-04 21:00:00")},
                new Trip { BusId=1, RouteId=2, Date=Convert.ToDateTime("2018-04-04 21:00:00")},
            };

            trips.ForEach(m => context.Trips.Add(m));
            //context.SaveChanges();

            var tickets = new List<Ticket>
            {
                new Ticket { TicketId=1, UserId = 3, TripId = 1, DatePoll= Convert.ToDateTime("2018-01-02 01:00:00"), CountOfTickets = 3},
                new Ticket { TicketId=2, UserId = 4, TripId = 1, DatePoll= Convert.ToDateTime("2018-01-02 02:00:00"), CountOfTickets = 3}
            };

            tickets.ForEach(m => context.Tickets.Add(m));
            //context.SaveChanges();

            /*
            var messages = new List<Message>
            {
                new Message { MessageID=1, MessageText="тест1", UserId = 1},
                new Message { MessageID=2, MessageText="тест2", UserId = 2},
                new Message { MessageID=3, MessageText="тест3", UserId = 3},
                new Message { MessageID=4, MessageText="тест4", UserId = 1},
                new Message { MessageID=5, MessageText="тест5", UserId = 2},
                new Message { MessageID=6, MessageText="тест4", UserId = 3}
            };

            messages.ForEach(m => context.Messages.Add(m));
            */

            context.SaveChanges();
        }
    }
}