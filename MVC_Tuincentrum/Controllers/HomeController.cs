﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Tuincentrum.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Soorent()
        {
            return Redirect("Soort");
        }

        public ActionResult Leveranciers()
        {
            return Redirect("Leverancier");
        }

        public ActionResult Planten()
        {
            return Redirect("Plant");
        }
    }
}