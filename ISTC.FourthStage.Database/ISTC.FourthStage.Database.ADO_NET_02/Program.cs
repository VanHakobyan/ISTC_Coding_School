using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FourthStage.Database.ADO_NET_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Connector.GetStartups();
            Console.ReadKey();
        }
    }
}
