using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PD.Api;
using PD.Api.DataTypes;
using PD.CLI.CORE.Core;

namespace PD.CLI.CORE.Api {

    public class AdminProcessMethods : IAdminProcessMethods {

        private readonly ISettings _settings; 
        private readonly IProcessManager _processRepository;

        public AdminProcessMethods( ISettingsFactory settings, IProcessManager processRepository ) {
            _settings = settings.Get();
            _processRepository = processRepository;
        }

        public async Task<IEnumerable<IDemonizedProcessBase>> List() => (await _processRepository.List().ConfigureAwait(false));

        public async Task<IEnumerable<IRunningDemonizedProcess>> ListFull() => (await _processRepository.ListFull().ConfigureAwait( false ));

        public async Task Edit( IPasswordedDemonizedProcess model ) {
            if ( model == null ) {
                throw new ArgumentNullException(nameof( model ));
            }
            var existing = await _processRepository.Get( model.Id ).ConfigureAwait( false );
            await _processRepository.Edit(model).ConfigureAwait( false );
            //todo: update model
        }

        public async Task<int> Create( IPasswordedDemonizedProcess model ) => await _processRepository.Create(model).ConfigureAwait(false);

        public async Task<IRunningDemonizedProcess> Get( int id ) => await _processRepository.Get( id ).ConfigureAwait( false ) ;

        public async Task Start( int id ) => await(await _processRepository.Get(id).ConfigureAwait(false)).Start().ConfigureAwait(false);

        public async Task Stop( int id ) => await(await _processRepository.Get(id).ConfigureAwait(false)).Stop().ConfigureAwait(false);

        public async Task Restart( int id ) => await(await _processRepository.Get(id).ConfigureAwait(false)).Restart().ConfigureAwait(false);

        public async Task Delete( int id ) => await _processRepository.Delete( id ).ConfigureAwait( false );

        public async Task Show( int id ) => await(await _processRepository.Get(id).ConfigureAwait(false)).Show().ConfigureAwait(false);

        public async Task Hide( int id ) => await ( await _processRepository.Get( id ).ConfigureAwait( false ) ).Hide().ConfigureAwait( false );

    }

}