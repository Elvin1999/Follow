using FollowUserWorks.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FollowUserWorks.AdditionalClasses
{
   public class Config
    {
        public List<MyProcess> AllProcesses { get; set; }
        public void SeriailizeProcessesToJson()
        {
            using (StreamWriter sw = new StreamWriter(App.Filename))
            {
                var item = JsonConvert.SerializeObject(AllProcesses);
                sw.WriteLine(item);
            }
        }
        public List<MyProcess> DeserializeProcessesFromJson()
        {
            try
            {
                var context = File.ReadAllText(App.Filename);
                AllProcesses = JsonConvert.DeserializeObject<List<MyProcess>>(context);
            }
            catch (Exception)
            {
            }
            return AllProcesses;
        }
    }
}


