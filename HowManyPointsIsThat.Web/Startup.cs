using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HowManyPointsIsThat.Web.Startup))]
namespace HowManyPointsIsThat.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
