namespace BookstoreDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Cost", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Cost");
        }
    }
}
