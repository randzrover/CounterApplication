using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(counterApplication1.Startup))]
namespace counterApplication1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
