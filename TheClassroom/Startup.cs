using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheClassroom.Startup))]
namespace TheClassroom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
