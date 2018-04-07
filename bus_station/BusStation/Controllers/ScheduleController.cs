using BusStation.DBContext;
using BusStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusStation.Controllers
{
    public class ScheduleController : Controller
    {

        private DBContent db = new DBContent();


        private static List<Ride> GetRides(DBContent db)
        {
            List<Ride> Rides = new List<Ride>();

            foreach (Trip trip in db.Trips)
            {
                Rides.Add(new Ride(trip.TripId));
            }
            return Rides;
        }

        // GET: Schedule
        public ActionResult Index()
        {
            return View(GetRides(db));
        }

    }
}
