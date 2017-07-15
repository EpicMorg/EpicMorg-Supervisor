namespace EMSV.Api.Client {

    public class ClientApi : IClientApi {

        public string Server { get; }

        public ClientApi( string server ) {
            Server = server;
            Process = new ClientProcessMethods( this );
        }

        public IClientProcessMethods Process { get; }

    }

}