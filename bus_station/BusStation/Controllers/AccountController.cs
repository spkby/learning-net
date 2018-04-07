using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

using BusStation.DBContext;
using BusStation.Models;

namespace BusStation.Controllers
{
    public class AccountController : Controller
    {

        // GET: Account/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        public ActionResult Login(Account account)
        {
            DBContent db = new DBContent();

            User user = db.Users.Where(u => u.Name.Equals(account.Login) && u.Password.Equals(account.Password)).FirstOrDefault();

            if (user != null && !user.Name.Equals(""))
            {
                FormsAuthentication.SetAuthCookie(account.Login, account.RememberMe);
            }
            else
            {
                ModelState.AddModelError("Error", "Wrong login or password");
                return View();
            }
            return RedirectToAction("Index", "Home");
        }


        // GET: Account/Logout
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }


        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Signup(User user)
        {
            DBContent db = new DBContent();
            int count = db.Users.Where(u => u.Name.Equals(user.Name)).Count();
            if (count != 0)
            {
                ModelState.AddModelError("Name", "Name is not available");
            }

            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();

                Account account = new Account();
                account.Login = user.Name;
                account.Password = user.Password;
                return Login(account);
            }

            return View();
        }

    }
}
