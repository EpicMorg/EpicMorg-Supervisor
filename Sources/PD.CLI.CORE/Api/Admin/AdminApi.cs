using PD.Api;

namespace PD.CLI.CORE.Api {

    public class AdminApi : IAdminApi {

        public AdminApi( IAdminProcessMethods process, ISettingsMethods settings, ILogMethods log ) {
            Process = process;
            Settings = settings;
            Log = log;
        }

        public IAdminProcessMethods Process { get; }
        public ISettingsMethods Settings { get; }
        public ILogMethods Log { get; }

    }

}