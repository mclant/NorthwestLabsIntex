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
    public class HomeController : Controller
    {
        // NorthwestLabs Database -> Hosted on Azure through Matt Lant's Account
        public NorthwestLabsContext db = new NorthwestLabsContext();

        public ActionResult Index()
        {
            ViewBag.SuccessfulLogout = LoginController.sLogout;
            ViewBag.SuccessfulRegister = LoginController.sLogin;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            

            return View();
        }
    }
}