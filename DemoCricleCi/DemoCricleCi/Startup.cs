using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoCricleCi.Startup))]
namespace DemoCricleCi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
