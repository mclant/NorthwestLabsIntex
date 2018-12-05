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
    public class CompanyInfoController : Controller
    {
        // New DBContext for the CompanyInfo controller
        NorthwestLabsContext db = new NorthwestLabsContext();

        // GET: AboutUs
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View(db.CompanyInfos.ToList());
        }

        public ActionResult LabPics()
        {
            return View();
        }

        public ActionResult Mission()
        {
            return View();
        }

        public ActionResult AboutCEO()
        {
            return View();
        }
    }
}