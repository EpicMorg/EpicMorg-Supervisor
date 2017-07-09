using System.Collections.Generic;
using System.Threading.Tasks;

namespace EMSV.Api.Client {

    public class LogMethods : MethodsBase, ILogMethods {

        private readonly AdminApi _api;

        public LogMethods( AdminApi api ) : base( api._server, "Admin/Log/" ) { _api = api; }

        public async Task<IEnumerable<string>> Show( int tailCount ) => await GetWithKey<string[]>($"{tailCount}", _api.Key).ConfigureAwait(false);

    }

}