using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vusen.TaskRunner
{
    public interface ITaskRunner
    {
        void Start();
        void Shutdown();
    }
}
