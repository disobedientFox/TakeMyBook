namespace TakeMyBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        author = c.String(),
                        publishingHouse = c.String(),
                        publishYear = c.Int(nullable: false),
                        pagesCount = c.Int(nullable: false),
                        Department_id = c.Int(),
                        Reader_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Departments", t => t.Department_id)
                .ForeignKey("dbo.Readers", t => t.Reader_id)
                .Index(t => t.Department_id)
                .Index(t => t.Reader_id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        address = c.String(),
                        country = c.String(),
                        city = c.String(),
                        openingHours = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Readers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        receivedPoints = c.Int(nullable: false),
                        spentPoints = c.Int(nullable: false),
                        score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Trades",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        IsGiven = c.Boolean(nullable: false),
                        book_id = c.Int(),
                        department_id = c.Int(),
                        reader_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Books", t => t.book_id)
                .ForeignKey("dbo.Departments", t => t.department_id)
                .ForeignKey("dbo.Readers", t => t.reader_id)
                .Index(t => t.book_id)
                .Index(t => t.department_id)
                .Index(t => t.reader_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trades", "reader_id", "dbo.Readers");
            DropForeignKey("dbo.Trades", "department_id", "dbo.Departments");
            DropForeignKey("dbo.Trades", "book_id", "dbo.Books");
            DropForeignKey("dbo.Books", "Reader_id", "dbo.Readers");
            DropForeignKey("dbo.Books", "Department_id", "dbo.Departments");
            DropIndex("dbo.Trades", new[] { "reader_id" });
            DropIndex("dbo.Trades", new[] { "department_id" });
            DropIndex("dbo.Trades", new[] { "book_id" });
            DropIndex("dbo.Books", new[] { "Reader_id" });
            DropIndex("dbo.Books", new[] { "Department_id" });
            DropTable("dbo.Trades");
            DropTable("dbo.Readers");
            DropTable("dbo.Departments");
            DropTable("dbo.Books");
        }
    }
}
