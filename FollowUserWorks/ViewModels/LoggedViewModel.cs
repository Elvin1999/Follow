using FollowUserWorks.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FollowUserWorks.ViewModels
{
   public class LoggedViewModel:BaseViewModel
    {
        private ObservableCollection<MyProcess> allLoggedProcess;
        public ObservableCollection<MyProcess> AllLoggedProcesses
        {
            get
            {
                return allLoggedProcess;
            }
            set
            {
                allLoggedProcess = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(AllLoggedProcesses)));
            }
        }
    }
}
