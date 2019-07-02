using FollowUserWorks.ViewModels;
using FollowUserWorks.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FollowUserWorks.Commands
{
    public class LoggedProcessCommand : ICommand
    {
        public LoggedProcessCommand(MainViewModel mainViewModel)
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
            LoggedViewModel loggedViewModel = new LoggedViewModel();
            loggedViewModel.AllLoggedProcesses = new ObservableCollection<Entities.MyProcess>();
            LoggedProcessWindow loggedProcessWindow = new LoggedProcessWindow(loggedViewModel);
            loggedProcessWindow.ShowDialog();
        }
    }
}
