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
            return View();
        }

        public ActionResult SalesEmployee()
        {
            return View(db.Customer.ToList());
        }

        public ActionResult PharmacologyHead()
        {
            
            return View(db.Invoice.ToList());
        }

        public ActionResult LabManager()
        {
            return View();
        }

        public ActionResult PharmacologyDirector()
        {
            return View();
        }

 /// <summary>
/// LABTECH
/// </summary>
        public ActionResult LabTech()
        {

            return View();
        }

        public ActionResult QuoteInbox()
        {

            return View(db.Order.ToList());
        }
 
        [HttpPost]
        public ActionResult QuoteInbox(int ordID, [Bind(Include = "OrderID,QuotePrice")] IQueryable<Orders> orders)
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
                db.Entry(orders).State = EntityState.Modified;
                db.SaveChanges();
                ViewBag.output = "Quote Recorded";
                return View();
            }

            return View(db.Order.ToList());
        }
        /// <summary>
        /// LABTECH
        /// </summary>

    }
}