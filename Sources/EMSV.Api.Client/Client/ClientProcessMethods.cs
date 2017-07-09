using System.Collections.Generic;
using System.Threading.Tasks;
using EMSV.Api.DataTypes;

namespace EMSV.Api.Client {

    public class ClientProcessMethods : MethodsBase, IClientProcessMethods {

        private readonly ClientApi _api;

        internal ClientProcessMethods( ClientApi api ) : base( api.Server, "Client/Process/" ) { _api = api; }

        public async Task<IEnumerable<IDemonizedProcessBase>> List() => await Get<DemonizedProcessBase[]>( "" ).ConfigureAwait( false );

        public async Task<IRunningDemonizedProcess> Get( int id, string key ) => await GetWithKey<RunningDemonizedProcess>( $"{id}", key ).ConfigureAwait( true );

        public async Task Start( int id, string key ) => await PostRaw( id, key, "Start" ).ConfigureAwait( false );

        public async Task Stop( int id, string key ) => await PostRaw( id, key, "Stop" ).ConfigureAwait( false );

        public async Task Restart( int id, string key ) => await PostRaw( id, key, "Restart" ).ConfigureAwait( false );

        public async Task<bool> CheckPassword( int id, string key ) => bool.Parse( await PostRaw( id, key, "CheckPassword" ).ConfigureAwait( false ) );

    }

}