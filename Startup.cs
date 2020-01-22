using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LuceMIS4200_940.Startup))]
namespace LuceMIS4200_940
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
