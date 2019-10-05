using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FourthStage.Database.EF.CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();
            context.Persons.Add(new Person { FirstName = "Luke", LastName = "Daniels", Age = 21 });
            context.SaveChanges();
            var persons = context.Persons.ToList();
            foreach (var person in persons)
            {
                Console.WriteLine($"{person.Id}:{person.FirstName} {person.LastName} {person.Age}");
            }
            
            context.Cars.Add(new Car { Name = "Kia", Person = persons.FirstOrDefault()});
            context.SaveChanges();
        }
    }
}
