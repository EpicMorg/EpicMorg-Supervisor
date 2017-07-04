using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PD.CLI.CORE.Core {

    public interface ILogManager {

        Task<IEnumerable<string>> Show( int tailCount );

        void Log( string s );

    }

    public class LogManager : ILogManager, IDisposable {

        private Stack<string> _repository;
        private IInternalSettings _settings;
        private StreamWriter writer;
        public LogManager( ISettingsFactory settings ) {
            _settings = settings.Get();
            _repository = new Stack<string>();
            if (_settings.LogPath!=null)
                writer = new StreamWriter( _settings.LogPath ) { AutoFlush = true };
        }

        public async Task<IEnumerable<string>> Show( int tailCount ) => _repository.AsEnumerable().Take( tailCount ).Reverse();

        public void Log( string s ) {
            string value = $"{DateTime.Now.ToString("G")}: {s}";
            Console.Out.WriteLine( value);
            writer?.WriteLine(value);
            _repository.Push(value);
        }

        public void Dispose() {
            writer.Dispose();
        }

    }

}