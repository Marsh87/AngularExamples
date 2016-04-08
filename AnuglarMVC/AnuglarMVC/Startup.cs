using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnuglarMVC.Startup))]
namespace AnuglarMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
