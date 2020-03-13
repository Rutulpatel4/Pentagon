using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pentagon.Startup))]
namespace Pentagon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
