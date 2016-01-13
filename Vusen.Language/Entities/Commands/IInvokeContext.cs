using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vusen.Shared;

namespace Vusen.Language.Entities.Commands
{
    public interface IInvokeContext
    {
        IServiceLocator ServiceLocator { get; }
    }
}
