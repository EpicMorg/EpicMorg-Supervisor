using System;
//using Microsoft.AspNet.Identity;
using Microsoft.Owin;
//using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup( typeof( EMSV.CLI.CORE.Server.Startup ) )]

namespace EMSV.CLI.CORE.Server {

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