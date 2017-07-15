using System;
using System.Threading.Tasks;
using EMSV.Api.Client;

namespace EMSV.CLI
{
    class Program {
        static void Main(string[] args) {
            MainAsync( args ).Wait();
        }

        private static async Task MainAsync( string[] args ) {
            var arguments = Arguments.Parse( args );
            var api = new ClientApi(arguments.Server);
            Func<int, string, Task> _;
            switch ( arguments.Action ) {
                case ProcessAction.Start:
                    _ = api.Process.Start;
                    break;
                case ProcessAction.Stop:
                    _ = api.Process.Stop;
                    break;
                case ProcessAction.Restart:
                    _ = api.Process.Restart;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            await _( arguments.Process, arguments.Key ).ConfigureAwait( false );
        }

    }

    public class Arguments {
        public string Server { get; set; }
        public string Key { get; set; }
        public int Process { get; set; }
        public ProcessAction Action { get; set; }

        /*
            PD.Cli [key] [action] [process] [server:port]
        */
        public static Arguments Parse( string[] args ) {
            return new Arguments() {
                Key = args[ 0 ],
                Action = (ProcessAction) Enum.Parse( typeof( ProcessAction ), args[ 1 ], true ),
                Process = int.Parse( args[ 2 ] ),
                Server = args[ 3 ]
            };
        }

    }

    public enum ProcessAction {

        Start,
        Stop,
        Restart

    }

}
