using System;
using System.Collections.Generic;

namespace ISTC.FourthStage.Database.ADO_NET.ADO_NET_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> peoples = Connector.GetPeople();
            //var peoples = Connector.GetPeopleUsingConnectionBuilder();
            foreach (var people in peoples)
            {
                Console.WriteLine($"{people.Id} {people.FirstName} {people.LastName} {people.Age}");
            }
            Console.ReadKey();
        }
    }
}
