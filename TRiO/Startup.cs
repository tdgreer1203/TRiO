using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TRiO.Startup))]
namespace TRiO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
