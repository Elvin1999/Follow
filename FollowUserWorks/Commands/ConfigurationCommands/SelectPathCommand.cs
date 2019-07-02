using FollowUserWorks.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Forms;

namespace FollowUserWorks.Commands.ConfigurationCommands
{
    public class SelectPathCommand : ICommand
    {
        public SelectPathCommand(ConfigurationViewModel configurationViewModel)
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
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if(fbd.ShowDialog() == DialogResult.OK)
            {
                string str = fbd.SelectedPath;
                //MessageBox.Show(str);
                App.Filename = str+"\\process.json";
            }
        }
    }
}
