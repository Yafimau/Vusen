using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vusen.Tasks.Persistance
{
    public interface ICodeRepository
    {
        string GetCode(string className);
    }
}
