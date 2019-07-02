using FollowUserWorks.AdditionalClasses;
using FollowUserWorks.Entities;
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
        public void SetProcess()
        {
            processViewModel.AllProcesses.Clear();
            var processes = Process.GetProcesses().Where(i => i.MainWindowTitle.Length > 0).ToList();
            foreach (var item in processes)
            {

                MyProcess myProcess = new MyProcess()
                {
                    StartTime = item.StartTime,
                    MainWindowTitle = item.MainWindowTitle,
                    ProcessName = item.ProcessName,
                    ThreadCount = item.Threads.Count
                };
                processViewModel.AllProcesses.Add(myProcess);
            }
        }
        ProcessViewModel processViewModel = new ProcessViewModel();
        public void Execute(object parameter)
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = new TimeSpan(10);
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            processViewModel.AllProcesses = new ObservableCollection<MyProcess>();
            SetProcess();
            Config config = new Config();
            config.AllProcesses = new List<MyProcess>(processViewModel.AllProcesses);
            config.SeriailizeWordsToJson();
            CurrentProcessWindow currentProcessWindow = new CurrentProcessWindow(processViewModel);
            dispatcherTimer.Start();
            currentProcessWindow.ShowDialog();
        }
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            SetProcess();
        }
    }
}
