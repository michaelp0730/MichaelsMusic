using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MichaelsMusic.Startup))]
namespace MichaelsMusic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
