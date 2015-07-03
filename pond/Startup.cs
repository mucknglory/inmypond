using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pond.Startup))]
namespace Pond
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
