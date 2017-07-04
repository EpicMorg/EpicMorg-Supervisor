using PD.Api;

namespace PD.CLI.CORE.Api {

    public class ClientApi : IClientApi {

        public ClientApi( IClientProcessMethods process ) {
            Process = process;
        }

        public IClientProcessMethods Process { get; }

    }

}