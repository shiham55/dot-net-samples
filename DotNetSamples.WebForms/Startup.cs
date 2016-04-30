using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotNetSamples.WebForms.Startup))]
namespace DotNetSamples.WebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
