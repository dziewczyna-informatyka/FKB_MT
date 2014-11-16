using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FKB_MT.Startup))]
namespace FKB_MT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
