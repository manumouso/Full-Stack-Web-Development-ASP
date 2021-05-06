using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Educacion.Startup))]
namespace Educacion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
