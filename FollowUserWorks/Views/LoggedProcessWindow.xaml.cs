using FollowUserWorks.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FollowUserWorks.Views
{
    /// <summary>
    /// Interaction logic for LoggedProcessWindow.xaml
    /// </summary>
    public partial class LoggedProcessWindow : Window
    {
        public LoggedViewModel LoggedViewModel { get; set; }
        public LoggedProcessWindow(LoggedViewModel LoggedViewModel)
        {
            InitializeComponent();
            this.LoggedViewModel = LoggedViewModel;
            DataContext = LoggedViewModel;
        }
    }
}



