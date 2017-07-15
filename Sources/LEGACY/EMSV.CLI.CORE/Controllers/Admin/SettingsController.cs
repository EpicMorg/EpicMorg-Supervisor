using System;
using System.Threading.Tasks;
using System.Web.Http;
using EMSV.Api;
using EMSV.Api.DataTypes;
using EMSV.CLI.CORE.Core;

namespace EMSV.CLI.CORE.Controllers
{
    [RoutePrefix("Admin/Settings")]
    public class SettingsController : ControllerBase
    {

        private readonly IAdminApi _api;
        private readonly ILogManager _log;

        public SettingsController( IAdminApi api, ILogManager log ) : base( api, log ) {
            _api = api;
            _log = log;
        }

        [HttpGet]
        [Route( "GetSettings" )]
        public async Task<ISettings> GetSettings([FromUri]string key) {
            _log.Log($"Loading settings as admin[{RemoteIp}]");
            await ThrowOnBadKey(key).ConfigureAwait(false);
            return await _api.Settings.GetSettings().ConfigureAwait(false);
        }
        [HttpPost]
        [Route("SetSettings")]
        public async Task SetSettings([FromUri]string key, Settings settings ) {
            _log.Log($"Updating settings as admin[{RemoteIp}]");
            await ThrowOnBadKey(key).ConfigureAwait(false);
            await _api.Settings.SetSettings( settings ).ConfigureAwait( false );
        }
        [HttpPost]
        [Route("SetKey")]
        public async Task SetKey([FromUri]string key, SetKeyK v ) {
            _log.Log($"Updating key as admin[{RemoteIp}]");
            await ThrowOnBadKey(key).ConfigureAwait(false);
            await _api.Settings.SetKey( v.newKey ).ConfigureAwait( false );
        }
        public class SetKeyK {

             public string newKey { get; set; }

        }
        [HttpPost]
        [Route("CheckKey")]
        public async Task<bool> CheckKey([FromUri] string key ) => await _api.Settings.CheckKey( key ).ConfigureAwait( false );

    }
}
