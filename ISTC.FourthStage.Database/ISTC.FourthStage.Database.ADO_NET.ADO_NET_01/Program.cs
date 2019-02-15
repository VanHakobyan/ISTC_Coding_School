using System;

namespace ISTC.FourthStage.Database.ADO_NET.ADO_NET_01
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
