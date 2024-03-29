﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnketaApp.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            TempData["Sifra"] = null;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            TempData["Sifra"] = null;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            TempData["Sifra"] = null;
            return View();
        }
    }
}