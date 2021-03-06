﻿/** Authors & Student Number:
    Siqian Yu 200286902
    Date Modified: 08-18-2016
    Short Version History: This is a Home Controller. 
    File Description: The home controller decides what to do wth the home view. 
    **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace COMP2006_S2016_FinalExamV2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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