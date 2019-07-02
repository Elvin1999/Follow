using FollowUserWorks.ViewModels;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }
    }
}
