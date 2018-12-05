﻿using System;
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
    public class ServicesController : Controller
    {
        // New db
        NorthwestLabsContext db = new NorthwestLabsContext();

        // GET: Services
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult PharmacologyCatalog()
        {
            return View(db.AssayType.ToList());
        }

        public ActionResult ProtocolNotebook()
        {
            return View(db.TestType.ToList());
        }
       
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
             AssayTypes assayTypes = db.AssayType.Find(id);
            if (assayTypes == null)
            {
                return HttpNotFound();
            }
            return View(assayTypes);
        }
    }
}