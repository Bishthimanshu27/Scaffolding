using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment1MakingClasses.Startup))]
namespace Assignment1MakingClasses
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
