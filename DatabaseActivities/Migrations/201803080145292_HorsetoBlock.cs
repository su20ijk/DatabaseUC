namespace DatabaseActivities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HorsetoBlock : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartingBase = c.Int(nullable: false),
                        StartingNumber = c.Int(nullable: false),
                        ActualNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HorsetoBlocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Horses = c.Double(nullable: false),
                        Blocks = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PoundToKiloes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pounds = c.Double(nullable: false),
                        Kilograms = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            CreateTable("dbo.MeterstoFeet", c => new
            {
                Id = c.Int(nullable: false, identity: true),
                Meters = c.Double(nullable: false),
                Feet = c.Double(nullable: false),
            })
            .PrimaryKey(t => t.Id);

            
                
                
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PoundToKiloes");
            DropTable("dbo.HorsetoBlocks");
            DropTable("dbo.Bases");
            DropTable("dbo.MeterstoFeet");
        }
    }
}
