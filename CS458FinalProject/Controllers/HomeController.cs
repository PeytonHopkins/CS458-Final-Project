using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CS458FinalProject.Controllers
{
    public class HomeController : Controller
    {
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

        [HttpPost]
        public ActionResult Authorize()
        {
            // get values from form 
            string username = Request.Form["username"];
            string password = Request.Form["password"];
            string userType = Request.Form["userType"];

            if (userType == "User")
            {
            }

            else if (userType == "Contractor")
            {
            }

            return View("Login");
        }
    }
}