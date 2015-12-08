using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Git_HelloWorld.Startup))]
namespace Git_HelloWorld
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
