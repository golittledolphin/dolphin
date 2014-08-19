using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Glp.Web.Startup))]
namespace Glp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
