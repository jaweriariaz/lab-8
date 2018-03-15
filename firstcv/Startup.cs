using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(firstcv.Startup))]
namespace firstcv
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
