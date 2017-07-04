using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using PD.Api;
using PD.Api.DataTypes;
using PD.CLI.CORE.Core;

namespace PD.CLI.CORE.Controllers {

    [RoutePrefix( "Client/Process" )]
    public class ClientProcessController : ApiController//, IClientProcessMethods {
    { 

        private readonly IClientApi _api;
        private readonly ILogManager _log;
        private string RemoteIp => Request.GetOwinContext()?.Request?.RemoteIpAddress;

        public ClientProcessController( IClientApi api, ILogManager log ) {
            _api = api;
            _log = log;
        }

        [Route( "" )]
        [HttpGet]
        public async Task<IEnumerable<IDemonizedProcessBase>> List() {
            _log.Log($"Listing processes[{RemoteIp}]");
            return await _api.Process.List().ConfigureAwait( false );
        }

        [HttpGet]
        [Route( "{id}" )]
        public async Task<IRunningDemonizedProcess> Get( int id, [FromUri] string key ) {
            _log.Log($"Showing {id}[{RemoteIp}]");
            return await _api.Process.Get( id, key).ConfigureAwait( false );
        }

        [HttpPost]
        [Route( "{id}/Start" )]
        public async Task Start( [FromUri] int id, [FromUri] string key ) {
            _log.Log($"Starting {id}[{RemoteIp}]");
            await _api.Process.Start( id, key).ConfigureAwait( false );
        }

        [HttpPost]
        [Route( "{id}/Stop" )]
        public async Task Stop( [FromUri] int id, [FromUri] string key)
        {
            _log.Log($"Stopping {id}[{RemoteIp}]");
            await _api.Process.Stop( id, key).ConfigureAwait( false );
        }

        [HttpPost]
        [Route( "{id}/Restart" )]
        public async Task Restart( [FromUri] int id, [FromUri] string key)
        {
            _log.Log($"Restarting {id}[{RemoteIp}]");
            await _api.Process.Restart( id, key).ConfigureAwait( false );
        }

        [HttpPost]
        [Route( "{id}/CheckPassword" )]
        public async Task<bool> CheckPassword( [FromUri] int id, [FromUri] string key ) {
            _log.Log( $"Checking password for {id}[{RemoteIp}]" );
            return await _api.Process.CheckPassword( id, key).ConfigureAwait( false );
        }
    }
    // FUCK FUCK FUCK FUCK FUCK FUCK FUCK FUCK FUCK FUCK FUCK FUCK FUCK FUCK
    // http://blog.codenamed.nl/2015/05/12/why-your-frombody-parameter-is-always-null/
    //public class KeyWrapper {

    //    [HttpBindRequired]
    //    public string Key { get; set; }

    //}
}