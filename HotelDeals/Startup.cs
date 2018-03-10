using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotelDeals.Startup))]
namespace HotelDeals
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
