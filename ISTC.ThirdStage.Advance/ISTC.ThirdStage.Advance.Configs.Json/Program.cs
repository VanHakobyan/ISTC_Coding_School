using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Formatting = System.Xml.Formatting;

//using Formatting = Newtonsoft.Json.Formatting;

namespace ISTC.ThirdStage.Advance.Configs.Json
{
    class Program
    {
        public static string XmlSerialization(List<StartUp> startUps)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(List<StartUp>));

            var xml = "";

            using (var sww = new StringWriter())
            {

                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, startUps);
                    xml = sww.ToString(); // Your XML
                }
            }

            return xml;
        }
        static void Main(string[] args)
        {
            List<StartUp> startUps = JsonConvert.DeserializeObject<List<StartUp>>(File.ReadAllText(@"E:\jsonstat.txt"));

            var istc = new StartUp
            {
                Company = "Istc",
                Capital = "1500 dram",
                City = "Yerevan",
                Link = "Istc.am"
            };

            startUps.Add(istc);

            var serializeObject = JsonConvert.SerializeObject(startUps, Newtonsoft.Json.Formatting.None);

            File.WriteAllText(@"E:\istc1.json", serializeObject);
            File.WriteAllText(@"E:\istc.xml", XmlSerialization(startUps));

            foreach (var startUp in startUps)
            {
                Console.WriteLine($"{startUp.Company} {startUp.Capital}");
            }

            Console.ReadKey();
        }
    }
}
