using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using NorthwestLabs.Models;
using NorthwestLabs.DAL;

namespace NorthwestLabs.Controllers
{
    public class ClientController : Controller
    {
        NorthwestLabsContext db = new NorthwestLabsContext();

        // GET: Client
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAQuote()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GetAQuote(Customers newcustomer)
        {
            
                newcustomer.logins.LoginUserName = newcustomer.LoginUserName;
           
                if (db.Login.Find(newcustomer.logins.LoginUserName) == null)
                {
                    db.Customer.Add(newcustomer);
                    db.SaveChanges();
                }
                else
                {
                    ViewBag.error = "The Username you entered is already in use. Please use another Username.";
                    return View();
                }

            Orders neworder = new Orders();
            neworder.CustomerID = newcustomer.CustomerID;
            neworder.OrderStatusID = 11;
            neworder.DateRequested = DateTime.Now;
            neworder.Quote = true;


            return View("PlaceOrder");
        }
    }
}