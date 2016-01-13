using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Vusen.Language.Entities.Params;
using Vusen.Shared.HttpClient;

namespace Vusen.Language.Entities.Commands.Http
{
    public class Get : Command
    {
        public override InvokeResult Invoke(InvokeContext context, params InvokeParameter[] parameters)
        {
            var result = new InvokeResult();

            if (parameters.Length != 1)
            {
                result.SetError(InvokeResult.ResultCode.MISSING_PARAMETER);
                return result;
            }

            var httpClient = context.ServiceLocator.ResolveService<IHttpClient>() as IHttpClient;

            httpClient.SendHttpRequest(HttpMethod.Get, (parameters[0] as StringParam).Value);
            

            return result;
        }
    }
}
