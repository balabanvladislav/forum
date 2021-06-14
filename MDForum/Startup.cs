using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MDForum.Startup))]
namespace MDForum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
