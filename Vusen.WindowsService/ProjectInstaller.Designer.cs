namespace Vusen.WindowsService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskRunnerServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.taskRunnerServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // taskRunnerServiceProcessInstaller
            // 
            this.taskRunnerServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.taskRunnerServiceProcessInstaller.Password = null;
            this.taskRunnerServiceProcessInstaller.Username = null;
            // 
            // taskRunnerServiceInstaller
            // 
            this.taskRunnerServiceInstaller.Description = "Vusen Tasks runner service";
            this.taskRunnerServiceInstaller.DisplayName = "Vusen task runner service";
            this.taskRunnerServiceInstaller.ServiceName = "Vusen.TaskRunnerService";
            this.taskRunnerServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.taskRunnerServiceProcessInstaller,
            this.taskRunnerServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller taskRunnerServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller taskRunnerServiceInstaller;
    }
}