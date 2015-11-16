using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ME2.Startup))]
namespace ME2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
