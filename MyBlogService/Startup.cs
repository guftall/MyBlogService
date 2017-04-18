using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyBlogService.Startup))]
namespace MyBlogService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
