using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vusen.Language
{
    using Vusen.Language.Entities;

    public class Interpreter
    {
        public RunResult Run(Script script)
        {
            this.CheckCode(script);

            return new RunResult
                       {
                           Code = ResultCode.Success
                       };
        }

        private void CheckCode(Script script)
        {
            
        }
    }
}
