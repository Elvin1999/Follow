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
using System.Windows.Threading;

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

        ProcessViewModel processViewModel = new ProcessViewModel();
        public void Execute(object parameter)
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = new TimeSpan(10);
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            var processes = Process.GetProcesses().Where(i => i.MainWindowTitle.Length > 0);
            processViewModel.AllProcesses = new ObservableCollection<Process>(processes);
            CurrentProcessWindow currentProcessWindow = new CurrentProcessWindow(processViewModel);
            dispatcherTimer.Start();
            currentProcessWindow.ShowDialog();
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            var processes = Process.GetProcesses().Where(i => i.MainWindowTitle.Length > 0);
            processViewModel.AllProcesses = new ObservableCollection<Process>(processes);
        }
    }
}
