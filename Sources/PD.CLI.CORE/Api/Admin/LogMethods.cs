using System.Collections.Generic;
using System.Threading.Tasks;
using EMSV.Api;
using EMSV.CLI.CORE.Core;

namespace EMSV.CLI.CORE.Api {

    public class LogMethods : ILogMethods {

        private ILogManager _repository;


        public LogMethods( ILogManager repository ) { _repository = repository; }


        public async Task<IEnumerable<string>> Show(int tailCount) => await _repository.Show(tailCount).ConfigureAwait(false);

    }

}