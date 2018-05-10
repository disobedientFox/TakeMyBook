namespace TakeMyBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addLogin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Readers", "nickname", c => c.String());
            AddColumn("dbo.Readers", "password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Readers", "password");
            DropColumn("dbo.Readers", "nickname");
        }
    }
}
