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
        public List<Process> MyProperty { get; set; }
        //public void SeriailizeWordsToJson()
        //{
        //    using (StreamWriter sw = new StreamWriter("words.json"))
        //    {
        //        var item = JsonConvert.SerializeObject(ForbiddenWords);
        //        sw.WriteLine(item);
        //    }
        //}
        //public List<ForbiddenWord> DeserializeWordsFromJson()
        //{
        //    try
        //    {
        //        var context = File.ReadAllText("words.json");
        //        ForbiddenWords = JsonConvert.DeserializeObject<List<ForbiddenWord>>(context);
        //    }
        //    catch (Exception)
        //    {
        //    }
        //    return ForbiddenWords;
        //}
    }
}
