using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SINServer.Startup))]
namespace SINServer
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
