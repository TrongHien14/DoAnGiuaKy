using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoAnGiuaKy.Startup))]
namespace DoAnGiuaKy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
