using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ff.cms.core.Startup))]
namespace ff.cms.core
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
