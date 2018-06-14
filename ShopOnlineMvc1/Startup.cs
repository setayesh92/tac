using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopOnlineMvc1.Startup))]
namespace ShopOnlineMvc1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
