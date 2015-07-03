using System.Web.Mvc;

namespace Pond.Web.Areas.Provider
{
    public class ProviderRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Provider";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Provider_default",
                "Provider/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}