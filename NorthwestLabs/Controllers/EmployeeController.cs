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
            if (LoginController.sUsername == null)
            { RedirectToAction("Login", "Login"); }

            return RedirectToAction("Index", "Admin");
        }

        public ActionResult SalesEmployee()
        {
            if (LoginController.sUsername == null)
            { RedirectToAction("Login", "Login"); }

            return View();
        }

        public ActionResult PharmacologyHead()
        {
            if (LoginController.sUsername == null)
            { RedirectToAction("Login", "Login"); }

            return View();
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

        public ActionResult LabWorker()
        {
            if (LoginController.sUsername == null)
            { RedirectToAction("Login", "Login"); }

            return View();
        }
    }
}