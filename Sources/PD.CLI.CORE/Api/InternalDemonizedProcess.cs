using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using EMSV.Api.DataTypes;
using EMSV.CLI.CORE.Core;

namespace EMSV.CLI.CORE.Api {

    public interface IInternalDemonizedProcess : IRunningDemonizedProcess, IPasswordedDemonizedProcess {

        int? ProcessId { get; }

        Task Start();

        Task Stop();

        Task Restart();

        Task Hide();

        Task Show();

    }

    public class InternalDemonizedProcess : RunningDemonizedProcess, IInternalDemonizedProcess {

        private readonly ILogManager _log;

        private readonly SemaphoreSlim _event = new SemaphoreSlim( 0, 1 );

        private readonly object statusLocker = new object();

        private ISettings _settings;

        private Process process;
        private readonly EventHandler _processOnExited;

        public InternalDemonizedProcess( ISettingsFactory settings, ILogManager log ) {
            _log = log;
            _settings = settings.Get();
            _processOnExited = ( a, b ) => {
                OnExit();
            };
        }

        public override ProcessPriorityClass? CurrentPriority => IsRunning() ? process.PriorityClass : (ProcessPriorityClass?) null;

        public virtual string Key { get; set; }

        public virtual int? ProcessId => IsRunning() ? process.Id : (int?) null;

        public async Task Start() {
            if ( Status != Status.NotRunning ) return;
            lock ( statusLocker ) {
                if ( Status != Status.NotRunning ) return;
                Status = Status.Starting;
            }
            StartInternal().ConfigureAwait( false ); //sic!
            lock ( statusLocker )
                if (Status==Status.Starting)
                    Status = Status.Running;
        }

        public async Task Stop() {
            if ( Status != Status.Running ) return;
            lock ( statusLocker ) {
                if ( Status != Status.Running ) return;
                Status = Status.Stopping;
            }
            await StopInternal().ConfigureAwait( false );
            lock ( statusLocker ) Status = Status.NotRunning;
        }

        public async Task Restart() {
            if ( Status != Status.Running ) return;
            lock ( statusLocker ) {
                if ( Status != Status.Running ) return;
                Status = Status.Stopping;
            }
            await StopInternal().ConfigureAwait( false );
            Status = Status.Starting;
            await StartInternal().ConfigureAwait( false );
            lock ( statusLocker ) Status = Status.Running;
        }

        //https://msdn.microsoft.com/en-us/library/windows/desktop/ms633548(v=vs.85).aspx

        public async Task Hide() => SendCommandToMainWindow( 0 );

        public async Task Show() => SendCommandToMainWindow( 5 );

        private void SendCommandToMainWindow( int nCmdShow ) {
            if ( !IsRunning() ) return;
            if ( process.MainWindowHandle == IntPtr.Zero ) return;
            ShowWindow( process.MainWindowHandle, nCmdShow );
        }

        [DllImport( "user32.dll" )]
        private static extern bool ShowWindow( IntPtr hwnd, int nCmdShow );

        private bool IsRunning() {
            return process != null && !process.HasExited; //check
        }

        private async Task StopInternal() {
            if ( !IsRunning() ) return;
            try {
                _log.Log( $"Killing [{Id}/{Name}]" );
                process.Kill();
            }
            catch ( Exception e ) {
                _log.Log( $"Failed to stop [{Id}/{Name}]\r\nException: {e.Message}" );
            }
        }

        private async Task StartInternal() {
            try {
                Restarts = 0;

                var i = 0;
                do {
                    if ( i > 0 )
                        _log.Log( $"Restarting [{Id}/{Name}] {i}/{_settings.RestartLimit}" );
                    try {
                        _log.Log( $"Starting process [{Id}/{Name}] : {Path} {Arguments}" );
                        CreateProcess();
                        process.Start();
                        process.PriorityClass = Priority;
                        await _event.WaitAsync().ConfigureAwait( false );
                    }
                    catch ( Exception ex ) {
                        process = null;
                        _log.Log( $"Failed to start [{Id}/{Name}] : {Path} {Arguments}\r\nException:{ex.Message}" );
                        _event.Release();
                        break;
                    }
                    finally {
                        if (process!=null)
                            process.Exited -= _processOnExited;
                    }
                    Restarts++;
                    i++;
                } while ( i < _settings.RestartLimit && Status == Status.Running && Autorestart );
            }
            finally {
                lock ( statusLocker ) {
                    if ( Status == Status.Running||Status==Status.Starting )
                        Status = Status.NotRunning;
                }
            }
        }

        private void CreateProcess() {
            process = new Process {
                StartInfo = {
                    Arguments = Arguments,
                    FileName = Path,
                    CreateNoWindow = HideOnStart,
                    WindowStyle = HideOnStart ? ProcessWindowStyle.Hidden : ProcessWindowStyle.Normal,
                    UseShellExecute = false,
                    WorkingDirectory = System.IO.Path.GetDirectoryName(Path),
                },
                EnableRaisingEvents = true,
            };
            process.Exited += _processOnExited;
        }

        private void OnExit() {
            _log.Log( $"Exited process [{Id}/{Name}] : {Path} {Arguments}" );
            _event.Release();
            process.Exited -= _processOnExited;
        }

    }

}