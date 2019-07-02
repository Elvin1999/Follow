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
using System.Windows;
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
        public bool IsFirstTime { get; set; }
        public ProcessHelper ProcessHelper { get; set; }
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
            if (!IsFirstTime)
            {
                IsFirstTime = true;
                ProcessHelper.TemproraryProcessList = new List<MyProcess>(processViewModel.AllProcesses);
            }
        }
        ProcessViewModel processViewModel = new ProcessViewModel();
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public void Execute(object parameter)
        {
            ProcessHelper = new ProcessHelper();

            dispatcherTimer.Interval = new TimeSpan(10);
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            processViewModel.AllProcesses = new ObservableCollection<MyProcess>();
            SetProcess();
            Config config = new Config();
            config.AllProcesses = new List<MyProcess>(processViewModel.AllProcesses);
            config.SeriailizeProcessesToJson();
            CurrentProcessWindow currentProcessWindow = new CurrentProcessWindow(processViewModel);
            dispatcherTimer.Start();
            currentProcessWindow.ShowDialog();
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            SetProcess();
            var original_list_count = processViewModel.AllProcesses.Count;
            var temporary_list_count = ProcessHelper.TemproraryProcessList.Count;
            if (original_list_count != temporary_list_count)
            {
                //var original_List = new List<MyProcess>(processViewModel.AllProcesses);
                //var isSameData = ProcessHelper.IsSameData(ProcessHelper.TemproraryProcessList, original_List);

                var originalList = processViewModel.AllProcesses.OrderByDescending(x => x.StartTime).ToList();
                var temporaryList = ProcessHelper.TemproraryProcessList.OrderByDescending(x => x.StartTime).ToList();
                var time1 = originalList[0].StartTime;
                var time2 = temporaryList[0].StartTime;
                MyProcess data;
                if (time1 > time2)
                {
                    data = originalList[0];
                    //MessageBox.Show(data.StartTime.ToLongTimeString());
                }
                else
                {
                    data = temporaryList[0];
                    //MessageBox.Show(data.StartTime.ToLongTimeString());
                }
                ProcessHelper.TemproraryProcessList = new List<MyProcess>(processViewModel.AllProcesses);
                Config config = new Config()
                {
                    AllProcesses = ProcessHelper.TemproraryProcessList
                };
                config.SeriailizeProcessesToJson();
            }
            else
            {

            }
        }
    }
}
