using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Notebook.Startup))]
namespace Notebook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
