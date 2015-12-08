using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vusen.Tasks;

namespace Vusen.TaskRunner.Persistance
{
    public interface ITaskRepository
    {
        IEnumerable<IVusenTask> GetTasks();
    }
}
