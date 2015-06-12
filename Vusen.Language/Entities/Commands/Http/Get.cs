using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vusen.Language.Entities.Commands.Http
{
    public class Get : Command
    {
        public override InvokeResult Invoke(InvokeContext context, params InvokeParameter[] parameters)
        {
            var result = new InvokeResult();

            if (parameters.Length == 0)
            {
                result.SetError(InvokeResult.ResultCode.MISSING_PARAMETER);
                return result;
            }

            return result;
        }
    }
}
