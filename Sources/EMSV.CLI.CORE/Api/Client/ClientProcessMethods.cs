using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EMSV.Api;
using EMSV.Api.DataTypes;
using EMSV.CLI.CORE.Core;

namespace EMSV.CLI.CORE.Api {

    public class ClientProcessMethods : IClientProcessMethods {

        private IProcessManager _processRepository;

        public ClientProcessMethods( IProcessManager processRepository ) {
            _processRepository = processRepository;
        }

        public async Task<IEnumerable<IDemonizedProcessBase>> List() => ( await _processRepository.List().ConfigureAwait( false ) );

        public async Task<IRunningDemonizedProcess> Get( int id, string key ) => await GetInternal( id, key ).ConfigureAwait( false );

        private async Task<IInternalDemonizedProcess> GetInternal( int id, string key ) {
            var ret = await GetInternal( id ).ConfigureAwait( false );
            if ( !CheckPasswordInternal( key, ret ) )
                throw new UnauthorizedAccessException( $"bad key while trying to acccess process {ret.Id}" );
            return ret;
        }

        private async Task<IInternalDemonizedProcess> GetInternal( int id ) {
            var ret = await _processRepository.Get( id ).ConfigureAwait( false );
            return ret;
        }

        private static bool CheckPasswordInternal( string key, IInternalDemonizedProcess ret ) {
            return ret?.Key == key;
        }

        public async Task Start( int id, string key ) => await ( await GetInternal( id, key ).ConfigureAwait( false ) ).Start().ConfigureAwait( false );

        public async Task Stop( int id, string key ) => await ( await GetInternal( id, key ).ConfigureAwait( false ) ).Stop().ConfigureAwait( false );

        public async Task Restart( int id, string key ) => await ( await GetInternal( id, key ).ConfigureAwait( false ) ).Restart().ConfigureAwait( false );

        public async Task<bool> CheckPassword( int id, string key ) {
            var ret = await GetInternal(id).ConfigureAwait(false);
            return CheckPasswordInternal(key, ret);
        }

    }

}