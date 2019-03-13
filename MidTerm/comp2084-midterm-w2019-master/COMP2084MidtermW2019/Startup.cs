using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(COMP2084MidtermW2019.Startup))]
namespace COMP2084MidtermW2019
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
