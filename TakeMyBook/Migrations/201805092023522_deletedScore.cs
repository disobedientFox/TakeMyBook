namespace TakeMyBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedScore : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Readers", "score");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Readers", "score", c => c.Int(nullable: false));
        }
    }
}
