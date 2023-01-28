using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MehanicarskaRadnja.Startup))]
namespace MehanicarskaRadnja
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
