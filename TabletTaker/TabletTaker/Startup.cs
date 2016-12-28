using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TabletTaker.Startup))]
namespace TabletTaker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
