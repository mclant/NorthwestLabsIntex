using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthwestLabs.DAL;
using NorthwestLabs.Models;
using System.Data.Entity;

namespace NorthwestLabs.Controllers
{
    public class AdminController : Controller
    {
        private NorthwestLabsContext db = new NorthwestLabsContext();

        // This simply navigates to a "view under construction"
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}