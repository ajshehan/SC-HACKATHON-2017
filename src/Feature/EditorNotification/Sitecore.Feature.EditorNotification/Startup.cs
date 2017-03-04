using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sitecore.Feature.EditorNotification.Startup))]
namespace Sitecore.Feature.EditorNotification
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
