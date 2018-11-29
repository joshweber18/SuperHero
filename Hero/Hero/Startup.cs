using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hero.Startup))]
namespace Hero
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
