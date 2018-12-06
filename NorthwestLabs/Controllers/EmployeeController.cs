using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using NorthwestLabs.DAL;
using NorthwestLabs.Models;
using System.Net;

namespace NorthwestLabs.Controllers
{
    public class EmployeeController : Controller
    {
        // New db
        NorthwestLabsContext db = new NorthwestLabsContext();


        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Admin()
        {
            if (LoginController.sUsername == null)
            { RedirectToAction("Login", "Login"); }

            return RedirectToAction("Index", "Admin");
        }

        public ActionResult SalesEmployee()
        {
            if (LoginController.sUsername == null)
            { RedirectToAction("Login", "Login"); }

            return View(db.Customer.ToList());
        }

        public ActionResult PharmacologyHead()
        {
            if (LoginController.sUsername == null)
            { RedirectToAction("Login", "Login"); }

            return View(db.Invoice.ToList());
        }

        public ActionResult LabManager()
        {
            if (LoginController.sUsername == null)
            { RedirectToAction("Login", "Login"); }

            return View();
        }

        public ActionResult PharmacologyDirector()
        {
            if (LoginController.sUsername == null)
            { RedirectToAction("Login", "Login"); }

            return View();
        }

 /// <summary>
/// LABTECH
/// </summary>
        public ActionResult LabTech()
        {
            if (LoginController.sUsername == null)
            { RedirectToAction("Login", "Login"); }

            return View();
        }

        public ActionResult QuoteInbox()
        {
            return View(db.Order.ToList());
        }

        [HttpPost]
        public ActionResult QuoteInbox(int? quote)
        {

            // List<Orders> ord = new List<Orders>();
            //orders = db.Order.Where(i => i.OrderID == ordID);
            //Orders neworder = new Orders();
            //neworder = ord[0];
            //.QuotePrice = QuotePrice;
            //db.Entry(neworder).State = EntityState.Modified;
            //db.SaveChanges();

            if (ModelState.IsValid)
            {

                ViewBag.output = "Quote Recorded";
                return View(db.Order.ToList());
            }

            return View(db.Order.ToList());
        }
        /// <summary>
        /// LABTECH
        /// </summary>
  
    }
}
