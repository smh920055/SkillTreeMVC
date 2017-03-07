using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp_HomeWork.Startup))]
namespace WebApp_HomeWork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
