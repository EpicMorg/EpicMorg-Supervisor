using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using EMSV.Api.DataTypes;

namespace EMSV.Api.Client {

    public class SettingsMethods : MethodsBase, ISettingsMethods {

        private readonly AdminApi _api;

        public SettingsMethods( AdminApi api ) : base( api._server, "Admin/Settings/" ) { _api = api; }

        public async Task<bool> CheckKey( string key ) => bool.Parse( await PostRaw("CheckKey", key ).ConfigureAwait( false ) );

        public async Task<ISettings> GetSettings() => await GetWithKey<Settings>( "GetSettings", _api.Key ).ConfigureAwait( false );


        public async Task SetKey( string newkey ) => await GetResponse(
            await _client.PostAsync(
                GetKeyQuery( "SetKey", _api.Key ),
                new FormUrlEncodedContent( new[] { new KeyValuePair<string, string>( "newkey", newkey ) } )
            ).ConfigureAwait( false )
        ).ConfigureAwait( false );

        public async Task SetSettings( ISettings settings ) {
            await GetResponse(await _client.PostAsync(
                GetKeyQuery("SetSettings", _api.Key),
                new FormUrlEncodedContent(new[] {
                    new KeyValuePair<string, string>("LogPath", settings.LogPath),
                    new KeyValuePair<string, string>("RestartLimit", settings.RestartLimit.ToString(CultureInfo.InvariantCulture))
                })
            ).ConfigureAwait(false)
        ).ConfigureAwait(false);
        }
    }

}