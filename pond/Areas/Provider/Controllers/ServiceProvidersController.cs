using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Pond.Web.Areas.Provider.Controllers
{
    [RouteArea("Provider")]
    public class ServiceProvidersController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // Method to return a list of ServiceProviders in JSON
        [System.Web.Mvc.AcceptVerbs(HttpVerbs.Get)]
        public JsonResult GetServiceProviders()
        {
            var result = new List<string>();

            IList<string> List = new List<string>();
            List.Add("Duckmanton Plumbers (UK) Ltd.");
            List.Add("Duckmanton Plumbing supplies Ltd.");
            List.Add("Shane Fox Financial Consultants");
            List.Add("Frisky Fox Hair Designs");


            foreach (var item in List)
            {
                result.Add(item.ToString());
            }
                return Json(result.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}
