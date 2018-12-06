using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using NorthwestLabs.Models;
using NorthwestLabs.DAL;
using System.Data.Entity.Validation;

namespace NorthwestLabs.Controllers
{
    public class ClientController : Controller
    {
        // instantiates a new dbcontext for use in controller
        NorthwestLabsContext db = new NorthwestLabsContext();

        // GET: Client
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAQuote()
        {
            if (LoginController.sUsername == null)
            { RedirectToAction("Login", "Login"); }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GetAQuote(Customers newcustomer)
        {
            newcustomer.logins.LoginUserName = newcustomer.LoginUserName;

            if (ModelState.IsValid && db.Login.Find(newcustomer.logins.LoginUserName) == null)
            {
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
            
            ViewBag.CustomerID = newcustomer.CustomerID;
            ViewBag.CustomerName = newcustomer.CustomerName;

            return View("PlaceQuote");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PlaceQuote(Orders order, int var, string custname)
        {
            Orders neworder = new Orders();
            neworder.DueDate = order.DueDate;
            neworder.CustomerID = var;
            neworder.DateRequested = DateTime.Now;
            neworder.Quote = true;
            neworder.OrderStatusID = 11;
            neworder.RunAllTests = false;

            db.Order.Add(neworder);

            ViewBag.CustomerName = custname;
            ViewBag.CustomerID = var;

            return View("FinalizeQuote", db.AssayType.ToList());
        }

        public ActionResult QuoteThankYou(string var, string custname)
        {
            ViewBag.CustomerName = custname;
            ViewBag.AssayName = var;
            
            return View();
        }
        
    }
}
