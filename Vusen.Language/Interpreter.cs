using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vusen.Shared;
using Vusen.Shared.HttpClient;
using Vusen.Language.Entities;

namespace Vusen.Language
{
    public class Interpreter
    {
        private IHttpClient httpClient;
        private readonly IServiceLocator _serviceLocator;

        public Interpreter(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

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
            // to do: if uses http then check httpClient is set
        }


    }
}
