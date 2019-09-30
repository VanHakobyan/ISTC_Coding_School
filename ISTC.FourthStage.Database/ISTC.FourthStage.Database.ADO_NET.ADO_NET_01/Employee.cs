using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FourthStage.Database.ADO_NET.ADO_NET_01
{
    public class Employee
    {
        public int Id { get; set; }
        public string NameOfTheTraiteur { get; set; }
        public string Dirigeant { get; set; }
        public string ContactCommercial { get; set; }
        public string Adress { get; set; }
        public string TelephoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Fax { get; set; }
    }
}
