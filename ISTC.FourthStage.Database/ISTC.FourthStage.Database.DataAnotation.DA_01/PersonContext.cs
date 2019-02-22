namespace ISTC.FourthStage.Database.DataAnnotation.DA_01
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PersonContext : DbContext
    {
       
        public PersonContext()
            : base("name=PersonContext")
        {
        }

     
        public virtual DbSet<People> Peoples { get; set; }
    }

  
}