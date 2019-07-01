using FollowUserWorks.ViewModels;
using FollowUserWorks.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FollowUserWorks.Commands
{
    public class CurrentProcessCommand : ICommand
    {
        public CurrentProcessCommand(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public event EventHandler CanExecuteChanged;
        public MainViewModel MainViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ProcessViewModel processViewModel = new ProcessViewModel();
            var processes = Process.GetProcesses().Where(i => i.MainWindowTitle.Length > 0);
            processViewModel.AllProcesses = new ObservableCollection<Process>(processes);
            CurrentProcessWindow currentProcessWindow = new CurrentProcessWindow(processViewModel);
            currentProcessWindow.ShowDialog();
        }
    }
}
