using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(作业.Startup))]
namespace 作业
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
