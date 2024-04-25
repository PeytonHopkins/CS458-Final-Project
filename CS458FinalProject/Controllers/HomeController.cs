using CS458FinalProject.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CS458FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private CS458FinalProjectContext db = new CS458FinalProjectContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Register";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Login";

            return View();
        }

        public ActionResult Logout()
        {
            this.Session.Clear();
            return View();
        }

        [HttpPost]
        public ActionResult Authorize()
        {
            // get values from form 
            string username = Request.Form["username"];
            string password = Request.Form["password"];
            string userType = Request.Form["userType"];

            if (userType == "")
            {
                userType = "User"; // Default to User type if the user did not select a type
            }
            if (userType == "User")
            {
                List<User> users = db.Users.ToList();
                foreach (User u in users)
                {
                    if (u.Name == username && u.Password == password)
                    {
                        // Store the current user in a session
                        StoreUser(username, userType);
                        return View("Index");
                    }
                    else
                    {
                        // No found username and password
                    }
                }
            }
            else if (userType == "Contractor")
            { 
                List<Contractor> contractors = db.Contractors.ToList();
                foreach (Contractor c in contractors)
                {
                    if (c.Name == username && c.Password == password)
                    {
                        // Store the current user in a session
                        StoreUser(username, userType);
                        return View("Index");
                    }
                    else
                    {
                        // No found username and password
                    }
                }
            }

            return View("Login");
        }

        private void StoreUser(string username, string userType)
        {
            this.Session["Username"] = username;
            this.Session["UserType"] = userType;

            int id = -1;

            foreach(User u in db.Users.ToList())
            {
                if (u.Name == username)
                {
                    id = u.Id;
                }
            }

            this.Session["UserID"] = id;
        }

    }
}