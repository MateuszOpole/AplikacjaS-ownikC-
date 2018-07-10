using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BazaFilmów.Startup))]
namespace BazaFilmów
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
