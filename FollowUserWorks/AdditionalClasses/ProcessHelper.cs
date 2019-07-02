using FollowUserWorks.Entities;
using System;
using System.Collections.Generic;
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


