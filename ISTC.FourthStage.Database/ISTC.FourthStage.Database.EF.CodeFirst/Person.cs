using System.Collections.Generic;

namespace ISTC.FourthStage.Database.EF.CodeFirst
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public ICollection<Car> Cars { get; set; }
    }

    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Year { get; set; }
        public virtual Person Person { get; set; }
    }
}
