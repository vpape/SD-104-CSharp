using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RPG_Hero.Startup))]
namespace RPG_Hero
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
