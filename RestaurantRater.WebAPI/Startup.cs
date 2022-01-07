using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestaurantRater.WebAPI.Startup))]
namespace RestaurantRater.WebAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
