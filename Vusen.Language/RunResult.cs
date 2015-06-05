using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vusen.Language
{
    using System.CodeDom.Compiler;

    public enum ResultCode
    {
        Success,
        Error
    }

    public class RunResult
    {
        public ResultCode CompilerCheckCode { get; set; }

        public ResultCode Code { get; set; }
    }
}
