namespace web_shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 100),
                        DescriptionCategory = c.String(nullable: false),
                        NameFileIcon = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        CourseID = c.Int(nullable: false, identity: true),
                        CategoryID = c.Int(nullable: false),
                        TitleCourse = c.String(nullable: false, maxLength: 100),
                        AuthorCourse = c.String(nullable: false, maxLength: 50),
                        DateAdded = c.DateTime(nullable: false),
                        NameFileImage = c.String(maxLength: 100),
                        DescriptionCourse = c.String(),
                        CoursePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Bestseller = c.Boolean(nullable: false),
                        Hidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CourseID)
                .ForeignKey("dbo.Category", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Street = c.String(nullable: false, maxLength: 100),
                        City = c.String(nullable: false, maxLength: 100),
                        PostalCode = c.String(nullable: false, maxLength: 6),
                        Phone = c.String(),
                        Email = c.String(),
                        Comment = c.String(),
                        DateAdded = c.DateTime(nullable: false),
                        OrderStatus = c.Int(nullable: false),
                        OrderValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderID);
            
            CreateTable(
                "dbo.OrderPosition",
                c => new
                    {
                        OrderPositionID = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        PurchasePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderPositionID)
                .ForeignKey("dbo.Course", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Order", t => t.OrderID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.CourseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderPosition", "OrderID", "dbo.Order");
            DropForeignKey("dbo.OrderPosition", "CourseID", "dbo.Course");
            DropForeignKey("dbo.Course", "CategoryID", "dbo.Category");
            DropIndex("dbo.OrderPosition", new[] { "CourseID" });
            DropIndex("dbo.OrderPosition", new[] { "OrderID" });
            DropIndex("dbo.Course", new[] { "CategoryID" });
            DropTable("dbo.OrderPosition");
            DropTable("dbo.Order");
            DropTable("dbo.Course");
            DropTable("dbo.Category");
        }
    }
}
