using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitRepoTestApp.Startup))]
namespace GitRepoTestApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
