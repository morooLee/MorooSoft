using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MorooSoft.Startup))]
namespace MorooSoft
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
