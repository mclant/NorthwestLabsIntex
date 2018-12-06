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

        // Getters and Setters for LoginUsername and Password
        public static string sUsername { get; set; }
        public static string sPassword { get; set; }

        // Getters and Setters for Login and Logout messages
        public static string sLogin { get; set; }
        public static string sLogout { get; set; }

        // GET: Login
        public ActionResult Login()
        { 
            if ((sUsername == "Labtech") && (sPassword == "Success"))
            {   // Labtech Login => navigates to the Labtech page to show Labtech tasks.
                sLogin = "You have successfully logged in.";
                sLogout = null;
                return RedirectToAction("LabTech", "Employee");
            }
            if ((sUsername == "Client") && (sPassword == "Success"))
            {   // Client Login => navigates to back to the home page with sucessful login message.
                sLogin = "You have successfully logged in.";
                sLogout = null;
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        //Login for existing customer -> will renavigate to the view they wanted after login
        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult LoginSuccess(FormCollection form)
        {
            sUsername = form["username"].ToString();
            sPassword = form["password"].ToString();

            if ((sUsername == "Client") && (sPassword == "Success"))
            {   // Client Login => navigates to back to the home page with sucessful login message.
                sLogin = "You have successfully logged in.";
                sLogout = null;
                return RedirectToAction("Index", "Home"); }
            if ((sUsername == "Labtech") && (sPassword == "Success"))
            {   // Labtech Login => navigates to the Labtech page to show Labtech tasks.
                sLogin = "You have successfully logged in.";
                sLogout = null;
            return RedirectToAction("LabTech", "Employee");}

            // Pages that are not currently linked to anything
                        if ((sUsername == "Admin") && (sPassword == "Success"))
                        { return RedirectToAction("Admin", "Employee"); }
                        if ((sUsername == "Director") && (sPassword == "Success"))
                        { return RedirectToAction("<<DIRECTOR VIEW AFTER LOGIN>>", "Employee"); }
                        if ((sUsername == "Finance") && (sPassword == "Success"))
                        {return RedirectToAction("LabTech", "Employee");}
            else
            {
                // This will navigate you back to the login page if authentication is unsuccessful
                ViewBag.UnsuccessfulLogin = "Your Username and/or password did not match our records. Please try again";
                return View("Login");
            }
        }

        //Returns view for new customer registration
        public ActionResult Registration()
        {
            return View();
        }

        //Registration for new customer
        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Registration(Customers newcustomer)
        {
            newcustomer.logins.LoginUserName = newcustomer.LoginUserName;

            if (ModelState.IsValid && db.Login.Find(newcustomer.logins.LoginUserName) == null)
            {
                sLogin = "Registration complete! You have successfully logged in.";
                sLogout = null;
                db.Customer.Add(newcustomer);
                db.SaveChanges();
            }
            else
            {
                if (db.Login.Find(newcustomer.logins.LoginUserName) != null)
                { 
                    ViewBag.error = "The Username you entered is already in use. Please use another Username.";
                }
                return View();
            }

            // Renavigates to the home page and shows successful registration and login viewbag
            return RedirectToAction("Index", "Home");
        }

        // Will log the user out of their current account.
        public ActionResult Logout()
        {
            // Resets global variables to null so that login again is required.
            sUsername = null;
            sPassword = null;

            // sets variable for sLogout to successful logout
            sLogout = "You have successfully logged out.";
            sLogin = null;

            // Returns to the home page
            return RedirectToAction("Index", "Home");
        }
    }
}
