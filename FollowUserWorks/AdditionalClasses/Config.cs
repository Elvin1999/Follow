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
        public void SeriailizeWordsToJson()
        {
            using (StreamWriter sw = new StreamWriter("words.json"))
            {
                var item = JsonConvert.SerializeObject(AllProcesses);
                sw.WriteLine(item);
            }
        }
        public List<MyProcess> DeserializeWordsFromJson()
        {
            try
            {
                var context = File.ReadAllText("words.json");
                AllProcesses = JsonConvert.DeserializeObject<List<MyProcess>>(context);
            }
            catch (Exception)
            {
            }
            return AllProcesses;
        }
    }
}
