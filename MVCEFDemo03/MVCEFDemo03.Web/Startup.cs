using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCEFDemo03.Web.Startup))]
namespace MVCEFDemo03.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
