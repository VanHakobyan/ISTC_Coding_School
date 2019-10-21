namespace ISTC.FourthStage.Database.FluentApi.FA01.Migrations
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
                        DoB = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Person", new[] { "Email" });
            DropTable("dbo.Person");
        }
    }
}
