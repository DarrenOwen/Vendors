using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vendors.Startup))]
namespace Vendors
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
