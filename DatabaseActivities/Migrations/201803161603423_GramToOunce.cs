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
                        Gram = c.Double(nullable: false),
                        Ounce = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MeterToFeet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Meters = c.Double(nullable: false),
                        Feet = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MeterToFeet");
            DropTable("dbo.GramToOunces");
        }
    }
}
