namespace MultiUserDbChanges.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Readers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blog", "Readers", c => c.Int(nullable: false));
            DropColumn("dbo.Blog", "Rating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Blog", "Rating", c => c.Int(nullable: false));
            DropColumn("dbo.Blog", "Readers");
        }
    }
}
