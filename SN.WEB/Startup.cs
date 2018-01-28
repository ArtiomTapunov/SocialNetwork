using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SN.WEB.Startup))]
namespace SN.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
