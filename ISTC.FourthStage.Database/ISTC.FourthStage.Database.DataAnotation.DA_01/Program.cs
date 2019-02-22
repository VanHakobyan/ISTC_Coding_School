using System;

namespace ISTC.FourthStage.Database.DataAnnotation.DA_01
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PersonContext context = new PersonContext())
            {
                People people = new People
                {
                    FirstName = "Armen",
                    LastName = "Ka",
                    BirthDate = DateTime.Now,
                    Age = 25
                };
                context.Peoples.Add(people);
                context.SaveChanges();

            }
        }
    }
}
