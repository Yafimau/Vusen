using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vusen.Shared.Logger;

namespace Vusen.WindowsService
{
    public class EventLogger : ILogger
    {
        private readonly EventLog _eventLog;

        public EventLogger(string source)
        {
            _eventLog = new EventLog
            {
                Source = source,
                Log = "Application"
            };
        }

        public void LogMessage(string message)
        {
            _eventLog.WriteEntry(message);
        }
    }
}
