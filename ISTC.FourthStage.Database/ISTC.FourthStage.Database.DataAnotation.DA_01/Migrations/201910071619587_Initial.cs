namespace ISTC.FourthStage.Database.DataAnnotation.DA_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 200),
                        LastName = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false, storeType: "date"),
                        Age = c.Int(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Person");
        }
    }
}
