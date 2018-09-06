using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyGitSample.Startup))]
namespace MyGitSample
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
