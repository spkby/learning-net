using MVC.DBContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Database.SetInitializer<DBContent>(new DBContenUserInit());
        }

        protected void Application_AcquireRequestState(object sender, EventArgs e)
        {
            if(HttpContext.Current.Session != null)
            {
                CultureInfo cultureInfo = (CultureInfo) this.Session["Culture"];
                if(cultureInfo == null)
                {
                    string lang = "ru";

                    if(HttpContext.Current.Request.UserLanguages != null &&
                        HttpContext.Current.Request.UserLanguages.Length != 0)
                    {
                        lang = HttpContext.Current.Request.UserLanguages[0].Substring(0, 2);
                    }

                    cultureInfo = new CultureInfo(lang);
                    this.Session["Culture"] = cultureInfo;
                }
                Thread.CurrentThread.CurrentUICulture = cultureInfo;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureInfo.Name);
            }
            
        }
    }
}
