namespace TakeMyBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addColumnTableBook : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "inStock", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "inStock");
        }
    }
}
