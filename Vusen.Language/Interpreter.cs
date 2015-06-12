using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vusen.Language
{
    using Vusen.Language.Entities;
    using Vusen.Language.HttpClient;

    public class Interpreter
    {
        private IHttpClient httpClient;

        public RunResult Run(Script script)
        {
            this.CheckCode(script);

            return new RunResult
                       {
                           Code = ResultCode.Success
                       };
        }

        public void SetHttpClient(IHttpClient client)
        {
            this.httpClient = client;
        }

        private void CheckCode(Script script)
        {
            // to do: if uses http then check httpClient is set
        }


    }
}
