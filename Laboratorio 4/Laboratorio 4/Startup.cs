using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Laboratorio_4.Startup))]
namespace Laboratorio_4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
