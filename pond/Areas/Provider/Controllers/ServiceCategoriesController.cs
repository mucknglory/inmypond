using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Pond.Web.Areas.Provider.Controllers
{
    [RouteArea("Provider")]
    public class ServiceCategoriesController : Controller
    {
        //
        // GET: /Home/

        [AcceptVerbs(HttpVerbs.Get)]
        public JsonResult GetServiceCategories()
        {
            var result = new List<string>();

            IList<string> List = new List<string>();
            List.Add("Plumbers");
            List.Add("Plumbing Supplies");
            List.Add("Hairdressers");
            List.Add("Car Valet Services");


            foreach (var item in List)
            {
                result.Add(item.ToString());
            }
            return Json(result.ToList(), JsonRequestBehavior.AllowGet);
        }

    }
}
