using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pond.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["SubTitle"] = "Welcome to the InMyPond.com Dashboard ";
            ViewData["Message"] = "";

            return View();
        }

        [AllowAnonymous]
        public ActionResult Pricing()
        {
            // TODO: Get Pricing from the database
            ViewData["BronzePricing"] = "5.99";
            ViewData["SilverPricing"] = "10.99";
            ViewData["GoldPricing"] = "19.99";
            ViewData["PlatinumPricing"] = "39.99";
            ViewData["Currency"] = "GBP";

            return View();
        }
        [AllowAnonymous]
            public ActionResult About()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Contact()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Team()
        {
            return View();
        }

        public ActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Terms()
        {
            return View();
        }
    }
}