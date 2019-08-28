using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.Collection.Coll03
{
    class Program
    {
        static void Main(string[] args)
        {
            PeopleCollection peopleCollection = new PeopleCollection();

            foreach (People people in peopleCollection)
            {
                Console.WriteLine($"name = {people.Name}, age = {people.Age}");
            }
        }
    }
}
