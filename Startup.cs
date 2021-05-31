using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Proyecto_ecommerce.Startup))]
namespace Proyecto_ecommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
