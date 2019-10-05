namespace ISTC.FourthStage.Database.EF.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ISTC.FourthStage.Database.EF.CodeFirst.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ISTC.FourthStage.Database.EF.CodeFirst.MyContext";
        }

        protected override void Seed(ISTC.FourthStage.Database.EF.CodeFirst.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
