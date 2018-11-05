namespace BookstoreDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        author = c.String(),
                        ISBN = c.String(),
                        CategoryID = c.String(),
                        Categories_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Categories_ID)
                .Index(t => t.Categories_ID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Categories_ID", "dbo.Categories");
            DropIndex("dbo.Books", new[] { "Categories_ID" });
            DropTable("dbo.Categories");
            DropTable("dbo.Books");
        }
    }
}
