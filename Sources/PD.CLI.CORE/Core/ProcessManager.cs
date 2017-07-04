using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PD.Api.DataTypes;
using PD.CLI.CORE.Api;
using PD.CLI.CORE.Helpers;

namespace PD.CLI.CORE.Core {

    public interface IProcessManager {

        Task<IInternalDemonizedProcess> Get( int id );

        Task<IEnumerable<IDemonizedProcessBase>> List();

        Task<IEnumerable<IInternalDemonizedProcess>> ListFull();

        Task<int> Create( IPasswordedDemonizedProcess model );

        Task Delete( int id );

        Task Edit( IPasswordedDemonizedProcess model );

    }

    public class ProcessManager : IProcessManager {

        /*
            i'm baked AF -> it'll suffer
        */


        private const string path = "processes.xml";

        private readonly IDataStorage<List<PasswordedDemonizedProcess>> _storage;

        private Dictionary<int, InternalDemonizedProcess> _processes; //stub

        private IInternalSettings _settings;

        private readonly object locker = new object();

        public ProcessManager( ISettingsFactory settings, IDataStorageFactory storage ) {
            _storage = storage.Get<List<PasswordedDemonizedProcess>>();

            var source = _storage.Load(path) ?? Enumerable.Empty<PasswordedDemonizedProcess>();

            _processes = source.Select( a => MappingHelper.Instance.Map<PasswordedDemonizedProcess, InternalDemonizedProcess>( a ) ).ToDictionary( process => process.Id, process => process );
            _settings = settings.Get();
        }

        private int NextId() => (_processes.Keys.Select(a => (int?)a).OrderBy(a => a).LastOrDefault() ?? 1) + 1; //fuck it

        private InternalDemonizedProcess GetInternal( int id ) {
            InternalDemonizedProcess ret = null;
            _processes.TryGetValue( id, out ret );
            return ret;
        }

        private void Save() => _storage.Save(path, _processes.Values.Select(a => MappingHelper.Instance.Map<InternalDemonizedProcess, PasswordedDemonizedProcess>(a)).ToList());

        public async Task<IInternalDemonizedProcess> Get( int id ) => GetInternal( id );

        public async Task<IEnumerable<IDemonizedProcessBase>> List()
            => _processes.Values.Select( a=>MappingHelper.Instance.Map<InternalDemonizedProcess, DemonizedProcessBase>( a ) );

        public async Task<IEnumerable<IInternalDemonizedProcess>> ListFull() {
            return _processes.Values; //todo: data updating
        }

        public async Task<int> Create( IPasswordedDemonizedProcess model ) {
            //i'm too lazy too implement it correctly(guids and stuff) but locking helps a little
            lock (locker) {
                try {
                    var insert = MappingHelper.Instance.Map<IPasswordedDemonizedProcess, InternalDemonizedProcess>( model ); //todo: actual mapping
                    insert.Id = NextId();
                    if ( insert.Priority == 0 )
                        insert.Priority = System.Diagnostics.ProcessPriorityClass.Normal;
                    _processes.Add(insert.Id, insert);
                    Save();
                    return insert.Id;
                }
                catch (Exception ex) {
                    Console.WriteLine( ex );
                    return -1;
                }
            }
        }

        public async Task Delete( int id ) {
            _processes.Remove( id );
            Save();
        }

        public async Task Edit( IPasswordedDemonizedProcess model ) {
            var existing = GetInternal( model.Id );
            MappingHelper.Instance.Map<IPasswordedDemonizedProcess, InternalDemonizedProcess>( model, existing );
        }

    }

}