using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Apollion.Startup))]
namespace Apollion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
