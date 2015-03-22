using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iys.Startup))]
namespace iys
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
