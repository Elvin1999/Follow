using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FollowUserWorks.ViewModels
{
   public class ProcessViewModel:BaseViewModel
    {
        private ObservableCollection<Process> allProcess;
        public ObservableCollection<Process> AllProcesses
        {
            get
            {
                return allProcess;
            }
            set
            {
                allProcess = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(AllProcesses)));
            }
        }
    }
}
