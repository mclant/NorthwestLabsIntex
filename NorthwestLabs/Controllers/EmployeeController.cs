using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using NorthwestLabs.DAL;
using NorthwestLabs.Models;

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
            return View();
        }

        public ActionResult PharmacologyHead()
        {
            return View();
        }

        public ActionResult LabManager()
        {
            return View();
        }

        public ActionResult PharmacologyDirector()
        {
            return View();
        }

        public ActionResult LabWorker()
        {
            return View();
        }
    }
}