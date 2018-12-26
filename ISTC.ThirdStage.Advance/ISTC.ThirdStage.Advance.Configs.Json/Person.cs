using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.Configs.Json
{
    public class Person
    {
        public string name { get; set; }
        public int[] phoneNumbers { get; set; }
        public bool isMen { get; set; }
        public string color { get; set; }
        public object carName { get; set; }
        public int age { get; set; }
        public Friends friends { get; set; }
    }

    public class Friends
    {
        public string a { get; set; }
        public string c { get; set; }
        public string e { get; set; }
    }

}
