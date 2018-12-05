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
        // instantiates a new dbcontext for use in controller
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
            db.Customer.Add(newcustomer);
            db.SaveChanges();
            

            return View();
        }
    }
}