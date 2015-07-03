using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pond.Web.Areas.Client.Controllers
{
    public class MessagesController : Controller
    {

        public ActionResult Inbox()
        {
            return View();
        }

        public ActionResult ViewMessage()
        {
            return View();
        }
    
        public ActionResult ComposeMessage()
        {
            return View();
        }
    
        public ActionResult MessageTemplates()
        {
            return View();
        }

        public ActionResult BasicActionMessage()
        {
            return View();
        }

        public ActionResult AlertMessage()
        {
            return View();
        }

        public ActionResult BillingMessage()
        {
            return View();
        }
	}
}