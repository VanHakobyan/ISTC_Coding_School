namespace ISTC.FourthStage.Database.DataAnnotation.DA_01.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ISTC.FourthStage.Database.DataAnnotation.DA_01.PersonContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ISTC.FourthStage.Database.DataAnnotation.DA_01.PersonContext";
        }

        protected override void Seed(ISTC.FourthStage.Database.DataAnnotation.DA_01.PersonContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
