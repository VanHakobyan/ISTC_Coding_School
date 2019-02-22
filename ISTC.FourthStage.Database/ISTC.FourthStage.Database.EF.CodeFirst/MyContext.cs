    using System.Data.Entity;

namespace ISTC.FourthStage.Database.EF.CodeFirst
{
    class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyContext")
        {
        }


        public virtual DbSet<Person> Persons { get; set; }
    }
}
