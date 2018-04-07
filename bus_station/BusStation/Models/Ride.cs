using BusStation.App_LocalResources;
using BusStation.DBContext;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BusStation.Models
{
    public class Ride
    {
        [Display(Name = nameof(Resource.number), ResourceType = typeof(Resource))]
        public string BusNumber { get; set; }

        [Display(Name = nameof(Resource.cityfrom), ResourceType = typeof(Resource))]
        public string RouteCityFrom { get; set; }

        [Display(Name = nameof(Resource.cityto), ResourceType = typeof(Resource))]
        public string RouteCityTo { get; set; }

        [Display(Name = nameof(Resource.date), ResourceType = typeof(Resource))]
        public DateTime Date { get; set; }

        private int TripId;

        [Display(Name = nameof(Resource.freeseats), ResourceType = typeof(Resource))]
        public int FreeSeats { get; set; }


        private DBContent db = new DBContent();

        public Ride(int tripId)
        {
            TripId = tripId;

            int BusId = GetBusId();
            int RouteId = GetRouteId();

            GetNumber(BusId);
            GetFreeSeats(BusId);

            GetRouteCityFrom(RouteId);
            GetRouteCityTo(RouteId);
            GetDate();
        }

        private void GetFreeSeats(int busId)
        {
            int seatsInBus = (from bus in db.Buses
                         where bus.BusId == busId
                         select bus.Seats).First();

            int[] sellSeatsArray = (from ticket in db.Tickets
                         where ticket.TripId == TripId
                         select ticket.CountOfTickets).ToArray();
            int allSellSeats = 0;
            foreach(int seats in sellSeatsArray)
            {
                allSellSeats += seats;
            }

            FreeSeats = seatsInBus - allSellSeats;

        }

        private int GetBusId()
        {
            return (from trip in db.Trips
                       where trip.TripId == TripId
                       select trip.BusId).First();
        }

        private string GetCity(int id)
        {
            return (from city in db.Cities
                      where city.CityId == id
                      select city.CityName).First();
        }

        private int GetRouteId()
        {
            var id = (from trip in db.Trips
                      where trip.TripId == TripId
                      select trip.RouteId);
            return id.First();
        }

        private void GetDate()
        {
            Date = (from trip in db.Trips
                      where trip.TripId == TripId
                      select trip.Date).First();
        }

        private void GetNumber(int busId)
        {
            BusNumber = (from bus in db.Buses
                         where bus.BusId == busId
                         select bus.Number).First();
        }

        private void GetRouteCityFrom(int routeId)
        {
            int cityIdFrom = (from route in db.Routes
                              where route.RouteId == routeId
                              select route.CityIdFrom).First();

            RouteCityFrom = GetCity(cityIdFrom);
        }

        private void GetRouteCityTo(int routeId)
        {
            int cityIdTo = (from route in db.Routes
                            where route.RouteId == routeId
                            select route.CityIdTo).First();

            RouteCityTo = GetCity(cityIdTo);
        }
    }
}