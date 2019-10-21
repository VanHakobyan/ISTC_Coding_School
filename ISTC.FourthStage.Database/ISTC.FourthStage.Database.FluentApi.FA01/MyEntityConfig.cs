using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FourthStage.Database.FluentApi.FA01
{
    public class MyEntityConfig : EntityTypeConfiguration<People>
    {

        public MyEntityConfig()
        {
            this.ToTable("Person")
                .HasKey(x => x.Id)
                .Ignore(x => x.LastName)
                .HasIndex(x => x.Email);

            this.Property(p => p.DateOfBirth)
                .HasColumnName("DoB")
                .HasColumnOrder(3)
                .HasColumnType("datetime2");

            this.Property(p => p.FirstName)
                .HasMaxLength(50);
            this.Property(x => x.Email).HasMaxLength(250).IsRequired();
        }
    }
}
