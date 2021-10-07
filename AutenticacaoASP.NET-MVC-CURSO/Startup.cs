using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.Cookies;

[assembly: OwinStartup(typeof(AutenticacaoASP.NET_MVC_CURSO.Startup))]

namespace AutenticacaoASP.NET_MVC_CURSO
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/Autenticacao/Login")
            });
           
        }
    }
}
