using NorthwestLabs.DAL;
using NorthwestLabs.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestLabs.Controllers
{
    public class LoginController : Controller
    {
        // New DB for NorthwestLabsContext
        NorthwestLabsContext db = new NorthwestLabsContext();

        // Getters and Setters for LoginUsername and 
        public string sUsername { get; set; }
        public string sPassword { get; set; }

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginSuccess(FormCollection form)
        {
            sUsername = form["username"].ToString();
            sPassword = form["password"].ToString();
            ViewBag.UnsuccessfulLogin = "Your Username and/or password did not match our records. Please try again";

            if ((sUsername == "Client") && (sPassword == "Success"))
            {return RedirectToAction("<<CLIENT VIEW AFTER LOGIN>>", "Client");}
            if ((sUsername == "Labtech") && (sPassword == "Success"))
            {return RedirectToAction("<<LABTECH VIEW AFTER LOGIN>>", "Employee");}
            if ((sUsername == "Admin") && (sPassword == "Success"))
            {return RedirectToAction("<<ADMIN VIEW AFTER LOGIN>>", "Employee");}
            if ((sUsername == "Director") && (sPassword == "Success"))
            {return RedirectToAction("<<DIRECTOR VIEW AFTER LOGIN>>", "Employee");}
            if ((sUsername == "Finance") && (sPassword == "Success"))
            {return RedirectToAction("<<FINANCE VIEW AFTER LOGIN>>", "Employee");}
            else
            {
                // This will navigate you back to the login page if authentication is unsuccessful
                return View("Login");
            }
        }
    }
}