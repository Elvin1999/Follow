﻿using FollowUserWorks.ViewModels;
using FollowUserWorks.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FollowUserWorks.Commands
{
    public class ConfigurationCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ConfigurationViewModel configurationViewModel = new ConfigurationViewModel();
            ConfigurationProcessWindow configurationProcessWindow = new ConfigurationProcessWindow(configurationViewModel);

        }
    }
}
