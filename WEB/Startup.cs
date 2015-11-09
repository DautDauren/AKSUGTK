using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AKSUGTK.WEB.Startup))]
namespace AKSUGTK.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
