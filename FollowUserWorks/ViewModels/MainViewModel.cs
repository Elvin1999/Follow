using FollowUserWorks.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FollowUserWorks.ViewModels
{
   public class MainViewModel:BaseViewModel
    {
        public CurrentProcessCommand CurrentProcessCommand => new CurrentProcessCommand(this);
        public LoggedProcessCommand LoggedProcessCommand=>new LoggedProcessCommand(this);
    }
}
