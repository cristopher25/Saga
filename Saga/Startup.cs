using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Saga.Startup))]
namespace Saga
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
