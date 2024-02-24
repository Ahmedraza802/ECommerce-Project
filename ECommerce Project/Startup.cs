using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ECommerce_Project.Startup))]
namespace ECommerce_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
