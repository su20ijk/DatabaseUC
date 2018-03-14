namespace DatabaseActivities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GramToOunce : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GramToOunces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Grams = c.Double(nullable: false),
                        Ounes = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GramToOunces");
        }
    }
}
