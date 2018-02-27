using System.Web;
using System.Web.Mvc;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TarefasMVC.Startup))]
namespace TarefasMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
                ConfigureAuth(app);
        }
    }
}
