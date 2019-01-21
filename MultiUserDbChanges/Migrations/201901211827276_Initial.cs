namespace MultiUserDbChanges.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Blog",
            //    c => new
            //        {
            //            BlogId = c.Int(nullable: false, identity: true),
            //            Url = c.String(maxLength: 250),
            //            DateAdded = c.DateTime(nullable: false, storeType: "date"),
            //            Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "timestamp"),
            //        })
            //    .PrimaryKey(t => t.BlogId);
            
            //CreateTable(
            //    "dbo.Post",
            //    c => new
            //        {
            //            PostId = c.Int(nullable: false, identity: true),
            //            Title = c.String(nullable: false, maxLength: 100),
            //            Content = c.String(),
            //            BlogId = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.PostId)
            //    .ForeignKey("dbo.Blog", t => t.BlogId, cascadeDelete: true)
            //    .Index(t => t.BlogId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Post", "BlogId", "dbo.Blog");
            DropIndex("dbo.Post", new[] { "BlogId" });
            DropTable("dbo.Post");
            DropTable("dbo.Blog");
        }
    }
}
