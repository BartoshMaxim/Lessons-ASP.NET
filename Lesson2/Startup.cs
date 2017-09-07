using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lesson2.Startup))]
namespace Lesson2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
