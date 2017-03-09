using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCEFDemo.Web.Startup))]
namespace MVCEFDemo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
