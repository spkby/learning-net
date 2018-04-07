using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;

namespace BusStation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Schedule()
        {
            return View();
        }

        public ActionResult ChangeCulture(string lang, string returnURL)
        {
            Session["Culture"] = new CultureInfo(lang);
            return Redirect(returnURL);
        }
    }
}