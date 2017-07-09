using System;
using System.Collections.Concurrent;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EMSV.CLI.CORE.Helpers
{
    public interface IDataStorage<T> {

        Task SaveAsync( string path, T value );

        Task<T> LoadAsync(string path);

        void Save(string path, T value);

        T Load(string path);
    }

    public class DataStorage<T> : IDataStorage<T> {
        //todo: in-memory cache
        private readonly ConcurrentDictionary<string, T> _cache;
        private readonly string _root;

        private static readonly XmlSerializer _Serializer = new XmlSerializer(typeof(T));

        public DataStorage( string root ) {
            _root = root;
            _cache = new ConcurrentDictionary<string, T>();
        }

        public async Task SaveAsync( string path, T value ) => Save( path, value );

        public async Task<T> LoadAsync( string path ) => Load( path );

        public void Save( string path, T value ) {
            _cache.AddOrUpdate( path, value, ( s, arg2 ) => value );
            using ( var f = File.Open( Resolve( path ), FileMode.OpenOrCreate, FileAccess.ReadWrite ) ) {
                f.SetLength( 0 );
                _Serializer.Serialize( f, value );
            }
        }
        public T Load( string path ) {
            T ret;
            if ( _cache.TryGetValue( path, out ret ) )
                return ret;
            var resolve = Resolve(path);
            if ( !File.Exists( resolve ) )
                return default(T);
            using ( var f = File.OpenRead( resolve ) ) {
                ret = (T) _Serializer.Deserialize( f );
                _cache.TryAdd(path, ret);
                return ret;
            }
        }

        private string Resolve(string path) { return Path.Combine(_root, path); }

    }

    public interface IDataStorageFactory {

        IDataStorage<T> Get<T>();

    }

    public class DataStorageFactory : IDataStorageFactory {

        private readonly string _path;

        public DataStorageFactory( string path ) {
            if ( !Directory.Exists( path ) )
                Directory.CreateDirectory( path );
            _path = path;
        }

        public IDataStorage<T> Get<T>() => new DataStorage<T>(_path);
    }

}
