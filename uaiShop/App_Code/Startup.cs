using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(uaiShop.Startup))]
namespace uaiShop
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
