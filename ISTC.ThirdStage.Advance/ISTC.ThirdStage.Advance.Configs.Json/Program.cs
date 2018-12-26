using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ISTC.ThirdStage.Advance.Configs.Json
{
    class Program
    {
        static void Main(string[] args)
        {
            var gevorJson = File.ReadAllText(@"C:\Users\vanik.hakobyan\source\gevor.json");
            List<Person> gevor = JsonConvert.DeserializeObject<List<Person>>(gevorJson);
        }
    }
}
