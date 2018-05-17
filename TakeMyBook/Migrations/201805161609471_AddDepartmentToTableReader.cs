namespace TakeMyBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDepartmentToTableReader : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Readers", "department_id", c => c.Int());
            CreateIndex("dbo.Readers", "department_id");
            AddForeignKey("dbo.Readers", "department_id", "dbo.Departments", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Readers", "department_id", "dbo.Departments");
            DropIndex("dbo.Readers", new[] { "department_id" });
            DropColumn("dbo.Readers", "department_id");
        }
    }
}
