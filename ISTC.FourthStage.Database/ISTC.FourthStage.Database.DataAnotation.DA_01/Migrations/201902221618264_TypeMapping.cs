namespace ISTC.FourthStage.Database.DataAnnotation.DA_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TypeMapping : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Person", "BirthDate", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Person", "BirthDate", c => c.DateTime(nullable: false));
        }
    }
}
