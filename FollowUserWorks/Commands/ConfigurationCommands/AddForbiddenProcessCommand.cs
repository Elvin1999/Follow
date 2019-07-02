using FollowUserWorks.Entities;
using FollowUserWorks.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FollowUserWorks.Commands.ConfigurationCommands
{
    public class AddForbiddenProcessCommand : ICommand
    {
        public AddForbiddenProcessCommand(ConfigurationViewModel configurationViewModel)
        {
            ConfigurationViewModel = configurationViewModel;

        }
        public event EventHandler CanExecuteChanged;
        public ConfigurationViewModel ConfigurationViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            var process_name = ConfigurationViewModel.ProcessName;
            //var item = Process.GetProcesses().SingleOrDefault(x => x.MainWindowTitle.Contains(process_name));
            //if (item != null)
            //{


                //MyProcess myProcess = new MyProcess()
                //{
                //    MainWindowTitle = item.MainWindowTitle,
                //    ProcessName = item.ProcessName,
                //    StartTime = item.StartTime,
                //    ThreadCount = item.Threads.Count
                //};
                ConfigurationViewModel.AllForbiddenProcesses.Add(process_name);
           // }
        }
    }
}
