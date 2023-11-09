using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Teste01.Startup))]
namespace Teste01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
