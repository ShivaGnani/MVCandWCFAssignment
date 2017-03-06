using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCandWCFAssignment.Startup))]
namespace MVCandWCFAssignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
