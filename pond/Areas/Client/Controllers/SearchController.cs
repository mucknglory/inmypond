using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pond.Web.Areas.Client.Controllers
{
    public class SearchController : Controller
    {

        // Unix time Epoch
        private static readonly DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        // GET: Search
        public ActionResult Search()
        {
            return View();
        }

        // GET: SearchResults
        public ActionResult SearchResults()
        {
            return View();
        }

        // GET: ShowAvailability
        public ActionResult ProviderAvailability()
        {
            return View();
        }

        // Get the availablility dates for a given date range
        /// <summary>
        /// Gets the calendar availablility dates for a given date range 
        /// and suppier id (optional)
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="SupplierID">If no SupplierId is passed it will search across all suppliers</param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Get)]
        public JsonResult GetProviderAvailability(DateTime start, DateTime end, int SupplierID)
        {
            var result = new List<string>();

            IList<DateTime> List = new List<DateTime>();

            List.Add(new DateTime(2015, 06, 15));
            List.Add(new DateTime(2015, 06, 15));
            List.Add(new DateTime(2015, 06, 15));
            List.Add(new DateTime(2015, 06, 16));
            List.Add(new DateTime(2015, 06, 17));
            List.Add(new DateTime(2015, 06, 17));
            List.Add(new DateTime(2015, 06, 19));
            List.Add(new DateTime(2015, 06, 19));
            List.Add(new DateTime(2015, 06, 19));
            List.Add(new DateTime(2015, 06, 19));
            List.Add(new DateTime(2015, 06, 19));
            List.Add(new DateTime(2015, 06, 20));
            List.Add(new DateTime(2015, 06, 20));
            List.Add(new DateTime(2015, 06, 24));
            List.Add(new DateTime(2015, 06, 24));
            List.Add(new DateTime(2015, 06, 24));

            var dates = new List<object>();

            dates.Add(new { date = ConvertToTimestamp(new DateTime(2015, 06, 15)), count = 10 });
            dates.Add(new { date = ConvertToTimestamp(new DateTime(2015, 06, 16)), count = 3 });
            dates.Add(new { date = ConvertToTimestamp(new DateTime(2015, 06, 17)), count = 1 });
            dates.Add(new { date = ConvertToTimestamp(new DateTime(2015, 06, 15)), count = 11 });
            dates.Add(new { date = ConvertToTimestamp(new DateTime(2015, 06, 18)), count = 6 });
            dates.Add(new { date = ConvertToTimestamp(new DateTime(2015, 06, 21)), count = 2 });

            return Json(dates, JsonRequestBehavior.AllowGet);

        }

        private static long ConvertToTimestamp(DateTime value)
        {
            TimeSpan elapsedTime = value - Epoch;
            return (long)elapsedTime.TotalSeconds;
        }
    }
}