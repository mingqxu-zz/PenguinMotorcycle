using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Penguin_Motorcycle.Startup))]
namespace Penguin_Motorcycle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
