using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vusen.Shared;

namespace Vusen.Language.Entities.Commands
{
    public class InvokeContext : IInvokeContext
    {
        private readonly IServiceLocator _serviceLocator;

        public InvokeContext(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public IServiceLocator ServiceLocator => _serviceLocator;
    }
}
