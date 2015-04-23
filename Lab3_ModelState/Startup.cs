using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3_ModelState.Startup))]
namespace Lab3_ModelState
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
