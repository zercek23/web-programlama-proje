using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_Proje.Startup))]
namespace Web_Proje
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
