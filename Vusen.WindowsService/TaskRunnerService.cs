using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Vusen.Shared.Logger;
using Vusen.TaskRunner;

namespace Vusen.WindowsService
{
    public partial class TaskRunnerService : ServiceBase
    {
        private readonly ILogger _logger;
        private readonly ITaskRunner _taskRunner;
        private ServiceStatus _serviceStatus;

        public enum ServiceState
        {
            SERVICE_STOPPED = 0x00000001,
            SERVICE_START_PENDING = 0x00000002,
            SERVICE_STOP_PENDING = 0x00000003,
            SERVICE_RUNNING = 0x00000004,
            SERVICE_CONTINUE_PENDING = 0x00000005,
            SERVICE_PAUSE_PENDING = 0x00000006,
            SERVICE_PAUSED = 0x00000007,
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ServiceStatus
        {
            public long dwServiceType;
            public ServiceState dwCurrentState;
            public long dwControlsAccepted;
            public long dwWin32ExitCode;
            public long dwServiceSpecificExitCode;
            public long dwCheckPoint;
            public long dwWaitHint;
        };

        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool SetServiceStatus(IntPtr handle, ref ServiceStatus serviceStatus);

        public TaskRunnerService()
        {
            InitializeComponent();
            _logger = new EventLogger(ServiceName);
            _taskRunner = new TaskRunner.TaskRunner();

            _serviceStatus = new ServiceStatus
            {
                dwCurrentState = ServiceState.SERVICE_STOPPED,
                dwWaitHint = 100000
            };

        }

        protected override void OnStart(string[] args)
        {
            _taskRunner.Start();
            SetServiceStatus(ServiceState.SERVICE_RUNNING);

            _logger.LogMessage($"{ServiceName} service started.");
        }

        protected override void OnStop()
        {
            _taskRunner.Shutdown();
            SetServiceStatus(ServiceState.SERVICE_STOPPED);

            _logger.LogMessage($"{ServiceName} service stopped.");
        }

        private void SetServiceStatus(ServiceState state)
        {
            _serviceStatus.dwCurrentState = state;
            SetServiceStatus(ServiceHandle, ref _serviceStatus);
        }
    }
}
