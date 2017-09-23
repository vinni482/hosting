using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hosting.Startup))]
namespace Hosting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
