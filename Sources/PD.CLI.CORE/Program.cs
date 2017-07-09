using System;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using EMSV.Api.DataTypes;
using EMSV.CLI.CORE.Core;
using EMSV.CLI.CORE.Server;

namespace EMSV.CLI.CORE {

    internal class Program {

        private static void Main(string[] args)
        {
            Di.Initialize(args.FirstOrDefault());
            Console.OutputEncoding = Encoding.Unicode;
            var prog = new Program(Di.Get<ILogManager>(), new FileConfiguration() { Url = ConfigurationManager.AppSettings["Address"] });
            prog.Start();
        }

        private readonly ILogManager _log;
        private readonly FileConfiguration _config;

        public Program( ILogManager log, FileConfiguration config ) {
            _log = log;
            _config = config;
        }

        private void Start() {
            var ts = new CancellationTokenSource();

            var server = StartWobServer(ts.Token);
            var pm = StartProcesses();
            //Task killa = StartKilla();
            Task.WhenAll( pm, server//, killa
                ).Wait(ts.Token);
        }

        private async Task StartKilla() {
            var prev = false;
            while ( true ) {
                try {
                    _log.Log("Restarting processes(killa)");
                    var now = DateTime.Now;
                    var restartInterval = 12;
                    if ( !prev && now.Hour % restartInterval == 0 && now.Minute==0) {
                        var pm = Di.Get<IProcessManager>();
                        var procs = await pm.ListFull().ConfigureAwait(false);
                        foreach (var proc in procs) { 
                            if (proc.Status== Status.Running)
                                await proc.Restart().ConfigureAwait(false);
                        }
                        prev = true;
                    }
                    else {
                        prev = false;
                    }
                }
                catch ( Exception e ) {
                    _log.Log( "Restart failed" );
                }
                await Task.Delay( 59000 );
            }
        }

        private async Task StartProcesses() {
            _log.Log( $"Starting processes & stuff" );
            var pm = Di.Get<IProcessManager>();
            var procs = await pm.ListFull().ConfigureAwait( false );
            foreach ( var proc in procs )
                await proc.Start().ConfigureAwait( false );
        }

        //xkcd:148
        private async Task StartWobServer( CancellationToken token ) {
            _log.Log( "Web server is starting up..." );
            using ( WebApp.Start<Startup>( _config.Url ) ) {
                Di.Get<ILogManager>().Log( $"Listening on {_config.Url}" );
                await Task.Delay( Timeout.InfiniteTimeSpan, token ).ConfigureAwait( false );
            }

        }

    }

}