using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FourthStage.Database.FluentApi.FA01
{
    public class MyContext:DbContext
    {
        public MyContext():base("name=MyContext")
        {}

        public virtual DbSet<People> Peoples { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MyEntityConfig());
        }
    }
}
