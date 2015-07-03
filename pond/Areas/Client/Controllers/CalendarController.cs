using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pond.Web.Areas.Client.Controllers
{

    public class CalendarController : Controller
    {

        //TODO: Example code that needs to be wired up to the database
        //CalendarDataContext db = new CalendarDataContext();

        /// <summary>
        /// JSON format Class to hold our calendar events
        /// </summary>
        public class JsonEvent
        {
            public string id { get; set; }
            public string text { get; set; }
            public string start { get; set; }
            public string end { get; set; }
        }

        // GET: Calendar
        public ActionResult Calendar()
        {
            return View();
        }


        /// <summary>
        /// Returns a JSON format array of events matching the specifed parameters
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        //public ActionResult Events(int? userId, DateTime? start, DateTime? end)
        //{
            // SQL: SELECT * FROM [event] WHERE NOT (([end] <= @start) OR ([start] >= @end))
            //var events = from ev in db.Events.AsEnumerable() where !(ev.End <= start || ev.Start >= end) select ev;

            //var result = events.Select(e => new JsonEvent()
            //{
            //    start = e.Start.ToString("s"),
            //    end = e.End.ToString("s"),
            //    text = e.Text,
            //    id = e.Id.ToString()
            //})
            //.ToList();

            //return new JsonResult { Data = result };
        //}

    }
}