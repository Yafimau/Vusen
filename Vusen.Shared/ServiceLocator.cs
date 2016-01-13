using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vusen.Shared
{
    public class ServiceLocator : IServiceLocator
    {
        IService IServiceLocator.ResolveService<T>()
        {
            throw new NotImplementedException();
        }
    }
}
