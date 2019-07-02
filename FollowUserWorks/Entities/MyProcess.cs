using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FollowUserWorks.Entities
{
   public class MyProcess
    {

        public string  MainWindowTitle { get; set; }
        public int ThreadCount { get; set; }
        public DateTime StartTime { get; set; }
        public string ProcessName { get; set; }
        public DateTime CloseDateTime { get; set; } = DateTime.Now;
    }
}
