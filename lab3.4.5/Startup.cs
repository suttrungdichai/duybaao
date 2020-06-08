using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab3._4._5.Startup))]
namespace lab3._4._5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
