using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Microhard.Startup))]
namespace Microhard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
