using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1Assignmnet.Startup))]
namespace _1Assignmnet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
