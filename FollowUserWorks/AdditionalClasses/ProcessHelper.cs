using FollowUserWorks.Entities;
using FollowUserWorks.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FollowUserWorks.AdditionalClasses
{
    public class ProcessHelper
    {
        public List<MyProcess> TemproraryProcessList { get; set; }
        public MyProcess GetNewProcess()
        {
            return new MyProcess();
        }
        private int check_counter = 0;
        public void KillForbiddenProcesses()
        {
            if (ConfigurationViewModel.AllForbiddenProcesses != null)
            {


                foreach (var item in ConfigurationViewModel.AllForbiddenProcesses)
                {
                    var item1 = Process.GetProcesses().SingleOrDefault(x => x.MainWindowTitle.Contains(item));
                    if (item1 != null)
                    {
                        MyProcess myProcess = new MyProcess()
                        {
                            MainWindowTitle = item1.MainWindowTitle,
                            ProcessName = item1.ProcessName,
                            StartTime = item1.StartTime,
                            ThreadCount = item1.Threads.Count
                        };
                        foreach (var item2 in TemproraryProcessList)
                        {
                            if (myProcess.MainWindowTitle == item2.MainWindowTitle)
                            {
                                var data = Process.GetProcesses().SingleOrDefault(x => x.MainWindowTitle.Contains(myProcess.MainWindowTitle));
                                if (data != null)
                                {
                                    data.Kill();
                                }
                            }
                        }
                    }

                }
            }
        }
        //public bool IsSameData(List<MyProcess> temporaryList,List<MyProcess> originalList)
        //{
        //    check_counter = 0;
        //    for (int i = 0; i < temporaryList.Count; i++)
        //    {
        //        if (temporaryList[i] == originalList[i])
        //        {
        //            ++check_counter;
        //        }
        //    }
        //    if (check_counter == temporaryList.Count)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}


