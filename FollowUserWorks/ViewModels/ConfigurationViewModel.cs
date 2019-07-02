using FollowUserWorks.Commands.ConfigurationCommands;
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
    public class ConfigurationViewModel : BaseViewModel
    {
        public AddForbiddenProcessCommand AddForbiddenProcessCommand => new AddForbiddenProcessCommand(this);
        public SelectPathCommand SelectPathCommand => new SelectPathCommand(this);
        private string processName;
        public string ProcessName
        {
            get
            {
                return processName;
            }
            set
            {
                processName = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(ProcessName)));
            }
        }
        public static List<string> AllForbiddenProcesses { get; set; }
    }
}





