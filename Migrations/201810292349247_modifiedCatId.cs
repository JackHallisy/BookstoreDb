namespace BookstoreDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifiedCatId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "Categories_ID", "dbo.Categories");
            DropIndex("dbo.Books", new[] { "Categories_ID" });
            AddColumn("dbo.Books", "Category", c => c.String());
            DropColumn("dbo.Books", "CategoryID");
            DropColumn("dbo.Books", "Categories_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Categories_ID", c => c.Int());
            AddColumn("dbo.Books", "CategoryID", c => c.String());
            DropColumn("dbo.Books", "Category");
            CreateIndex("dbo.Books", "Categories_ID");
            AddForeignKey("dbo.Books", "Categories_ID", "dbo.Categories", "ID");
        }
    }
}
