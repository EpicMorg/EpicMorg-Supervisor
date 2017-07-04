using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using PD.Api;
using PD.CLI.CORE.Core;

namespace PD.CLI.CORE.Controllers {

    public abstract class ControllerBase : ApiController {

        private readonly IAdminApi _api;
        private readonly ILogManager _log;

        public ControllerBase(IAdminApi api, ILogManager log) {
            _api = api;
            _log = log;
        }

        protected string RemoteIp => Request.GetOwinContext()?.Request?.RemoteIpAddress;

        protected async Task ThrowOnBadKey( string key ) {
            if ( !( await _api.Settings.CheckKey( key ).ConfigureAwait( false ) )) { 
                throw new UnauthorizedAccessException( $"Some faggot from [{RemoteIp}] tried to break into our system" );
            }
        }

        protected override ExceptionResult InternalServerError( Exception exception ) {
            _log.Log( exception.Message );
            return base.InternalServerError( exception );
        }

    }

}