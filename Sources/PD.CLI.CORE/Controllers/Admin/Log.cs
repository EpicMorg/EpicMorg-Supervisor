using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using PD.Api;
using PD.CLI.CORE.Core;

namespace PD.CLI.CORE.Controllers {

    [RoutePrefix("Admin/Log")]
    public class LogController : ControllerBase {

        private readonly IAdminApi _api;
        private readonly ILogManager _log;

        public LogController( IAdminApi api, ILogManager log ) : base( api, log ) {
            _api = api;
            _log = log;
        }
        [Route("{tailCount}")]
        [HttpGet]
        public async Task<IEnumerable<string>> Show( [FromUri] string key, [FromUri]int tailCount ) {
            _log.Log( $"Showing log({tailCount} lines) as admin[{RemoteIp}]" );
            await ThrowOnBadKey( key ).ConfigureAwait( false );
            return await _api.Log.Show( tailCount ).ConfigureAwait( false );
        }

    }

}