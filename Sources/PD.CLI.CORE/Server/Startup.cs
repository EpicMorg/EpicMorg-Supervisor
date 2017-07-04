using System;
//using Microsoft.AspNet.Identity;
using Microsoft.Owin;
//using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup( typeof( PD.CLI.CORE.Server.Startup ) )]

namespace PD.CLI.CORE.Server {

    public class Startup {

        public void Configuration( IAppBuilder app ) {
            app.UseWebApi( GlobalConfiguration.HttpConfiguration );
            //app.UseCookieAuthentication(
            //    new CookieAuthenticationOptions() { 
            //        AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
            //        ExpireTimeSpan = TimeSpan.FromMinutes(30),
            //        LoginPath = new PathString("/Authorize"),
            //        SlidingExpiration = true
            //    }
            //);
            //app.UseExternalSignInCookie( DefaultAuthenticationTypes.ExternalCookie );
        }

    }

}