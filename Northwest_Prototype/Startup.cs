using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Northwest_Prototype.Startup))]
namespace Northwest_Prototype
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
