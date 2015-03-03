using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(azure_test.web.Startup))]
namespace azure_test.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
