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
   public class ProcessViewModel:BaseViewModel
    {
        private ObservableCollection<MyProcess> allProcess;
        public ObservableCollection<MyProcess> AllProcesses
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
