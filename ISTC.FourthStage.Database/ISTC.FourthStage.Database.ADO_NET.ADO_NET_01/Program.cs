using System;
using System.Collections.Generic;

namespace ISTC.FourthStage.Database.ADO_NET.ADO_NET_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = Connector.GetEmployees();
            //var peoples = Connector.GetPeopleUsingConnectionBuilder();
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Id} {employee.NameOfTheTraiteur} {employee.Dirigeant} {employee.Adress}");
            }
            Console.ReadKey();
        }
    }
}
