namespace DatabaseActivities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GramToOunce : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GramToOunces", "Gram", c => c.Double(nullable: false));
            AddColumn("dbo.GramToOunces", "Ounce", c => c.Double(nullable: false));
            DropColumn("dbo.GramToOunces", "Grams");
            DropColumn("dbo.GramToOunces", "Ounes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GramToOunces", "Ounes", c => c.Double(nullable: false));
            AddColumn("dbo.GramToOunces", "Grams", c => c.Double(nullable: false));
            DropColumn("dbo.GramToOunces", "Ounce");
            DropColumn("dbo.GramToOunces", "Gram");
        }
    }
}
