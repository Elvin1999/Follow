using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FollowUserWorks
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string Filename;
        public App()
        {
            Filename = @"C:\Users\Documents\source\repos\FollowUserWorkWpfAsync\FollowUserWorks\bin\Debug\process.json";
        }
    }
}
