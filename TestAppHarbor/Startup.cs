using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAppHarbor.Startup))]
namespace TestAppHarbor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
