using System.Collections.Generic;
using System.Threading.Tasks;
using PD.Api;
using PD.CLI.CORE.Core;

namespace PD.CLI.CORE.Api {

    public class LogMethods : ILogMethods {

        private ILogManager _repository;


        public LogMethods( ILogManager repository ) { _repository = repository; }


        public async Task<IEnumerable<string>> Show(int tailCount) => await _repository.Show(tailCount).ConfigureAwait(false);

    }

}