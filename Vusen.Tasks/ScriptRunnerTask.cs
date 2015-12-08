using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vusen.Tasks.Persistance;

namespace Vusen.Tasks
{
    public class ScriptRunnerTask : VusenTaskBase
    {
        private readonly ICodeRepository _codeRepository;
        private readonly string _className;

        public ScriptRunnerTask(string taskName)
        {
            _className = taskName;
        }

        public override void Run()
        {
            var code = _codeRepository.GetCode(_className);
            // run code
            // check result
            // throw exception if not Ok
        }
    }
}
