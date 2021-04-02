using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoRentalApps.Startup))]
namespace VideoRentalApps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
