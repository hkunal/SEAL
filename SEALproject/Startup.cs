using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SEALproject.Startup))]
namespace SEALproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
