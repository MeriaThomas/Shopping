using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoppingUI.Startup))]
namespace ShoppingUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
