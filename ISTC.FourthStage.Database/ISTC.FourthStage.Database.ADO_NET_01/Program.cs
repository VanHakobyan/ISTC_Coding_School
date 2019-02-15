using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FourthStage.Database.ADO_NET_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //var peoples = Connector.GetPeople();
            var peoples = Connector.GetPeopleUsingConnectionBuilder();
            foreach (var people in peoples)
            {
                Console.WriteLine($"{people.Id} {people.FirstName} {people.LastName} {people.Age}");
            }

            Console.ReadKey();
        }
    }
}
