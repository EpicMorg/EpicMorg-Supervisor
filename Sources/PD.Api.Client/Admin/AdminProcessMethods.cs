using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using PD.Api.DataTypes;
using KVP = System.Collections.Generic.KeyValuePair<string, string>;

namespace PD.Api.Client {

    public class AdminProcessMethods : MethodsBase, IAdminProcessMethods {

        private readonly AdminApi _api;
        private string key => _api.Key;

        public AdminProcessMethods( AdminApi api ) : base( api._server, "Admin/Process/" ) { _api = api; }

        public async Task<IEnumerable<IDemonizedProcessBase>> List() => await GetWithKey<RunningDemonizedProcess[]>( "", key ).ConfigureAwait( false );

        public async Task<IEnumerable<IRunningDemonizedProcess>> ListFull() => await GetWithKey<RunningDemonizedProcess[]>( "ListFull", key ).ConfigureAwait( false );

        public async Task<IRunningDemonizedProcess> Get( int id ) => await GetWithKey<RunningDemonizedProcess>( $"{id}", key ).ConfigureAwait( false );

        public async Task Start( int id ) => await PostRaw( id, key, "Start" ).ConfigureAwait( false );

        public async Task Stop( int id ) => await PostRaw( id, key, "Stop" ).ConfigureAwait( false );

        public async Task Restart( int id ) => await PostRaw( id, key, "Restart" ).ConfigureAwait( false );

        public async Task Delete( int id ) => await PostRaw( id, key, "Delete" ).ConfigureAwait( false );

        public async Task Show( int id ) => await PostRaw( id, key, "Show" ).ConfigureAwait( false );

        public async Task Hide( int id ) => await PostRaw( id, key, "Hide" ).ConfigureAwait( false );

        public async Task Edit( IPasswordedDemonizedProcess model ) => await GetResponse( await _client.PostAsync( GetKeyQuery( "Edit", key ), ToContent( model ) ).ConfigureAwait( false ) ).ConfigureAwait( false );

        public async Task<int> Create( IPasswordedDemonizedProcess model ) => int.Parse( await GetResponse( await _client.PostAsync( GetKeyQuery( "", key ), ToContent( model ) ).ConfigureAwait( false ) ).ConfigureAwait( false ) );

        private static FormUrlEncodedContent ToContent( IPasswordedDemonizedProcess model ) => new FormUrlEncodedContent(
            new[] { 
                new KVP( nameof( model.Key ), model.Key ), new KVP( nameof( model.Arguments ), model.Arguments ), new KVP( nameof( model.Name ), model.Name ),
                new KVP( nameof( model.Path ), model.Path ), new KVP( nameof( model.Id ), model.Id.ToString( CultureInfo.InvariantCulture ) ),
                new KVP( nameof( model.Autorestart ), model.Autorestart.ToString( CultureInfo.InvariantCulture ) ),
                new KVP( nameof( model.Priority ), model.Priority.ToString() ),
                new KVP( nameof( model.HideOnStart ), model.HideOnStart.ToString( CultureInfo.InvariantCulture ) )
            } );

    }

}