using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToyStore_Lab.Startup))]
namespace ToyStore_Lab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
