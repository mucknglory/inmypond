using System.Web.Mvc;

namespace Pond.Web.Areas.Client
{
    public class ClientRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Client";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Client_default",
                "Client/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}