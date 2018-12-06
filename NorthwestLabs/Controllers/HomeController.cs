using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using NorthwestLabs.DAL;
using NorthwestLabs.Models;

/***********************************************************************************************************************************************
 * 
 *      Project:        INTEX IS CORE 2018
 *      Group:          2-13
 *      Authors:        Jon Facer
 *                      Matt Lant
 *                      Nate Flanagan
 *                      Rob Calcote
 *      Description:    Web application for Northwest Labs LLC. Provides full Client and Employee communication and Order passing functionality.
 *      Build:          1.0
 * 
 ***********************************************************************************************************************************************/

namespace NorthwestLabs.Controllers
{
    public class HomeController : Controller
    {
        // NorthwestLabs Database -> Hosted on Azure through Matt Lant's Account
        public NorthwestLabsContext db = new NorthwestLabsContext();

        // Landing Page
        public ActionResult Index()
        {
            ViewBag.SuccessfulLogin = LoginController.sLogin;
            ViewBag.SuccessfulLogout = LoginController.sLogout;

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