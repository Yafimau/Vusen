using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vusen.TaskRunner.Persistance;

namespace Vusen.TaskRunner
{
    public class TaskRunner : ITaskRunner
    {
        private ITaskRepository _taskPersister;

        public void Start()
        {
            var tasksToRun = _taskPersister.GetTasks();

        }

        public void Shutdown()
        {
            throw new NotImplementedException();
        }
    }
}
