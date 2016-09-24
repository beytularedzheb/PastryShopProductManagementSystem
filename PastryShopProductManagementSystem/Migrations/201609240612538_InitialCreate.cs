namespace PastryShopProductManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Desserts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductDetailDesserts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Dessert_Id = c.Int(),
                        ProductDetail_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Desserts", t => t.Dessert_Id)
                .ForeignKey("dbo.ProductDetails", t => t.ProductDetail_Id)
                .Index(t => t.Dessert_Id)
                .Index(t => t.ProductDetail_Id);
            
            CreateTable(
                "dbo.ProductDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50, unicode: false),
                        Unit = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InputDocuments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InputDocumentProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReceivingDate = c.DateTime(nullable: false),
                        ReceivedQuantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Vehicle = c.String(maxLength: 10, unicode: false),
                        Document = c.String(maxLength: 40, unicode: false),
                        InputDocument_Id = c.Int(),
                        Product_Id = c.Int(),
                        Provider_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.InputDocuments", t => t.InputDocument_Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Providers", t => t.Provider_Id)
                .Index(t => t.InputDocument_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Provider_Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BatchNumber = c.String(maxLength: 20, unicode: false),
                        AvailableQuantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StorageCondition = c.String(maxLength: 80, unicode: false),
                        ExpiryDate = c.DateTime(nullable: false),
                        ProductDetail_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductDetails", t => t.ProductDetail_Id)
                .Index(t => t.ProductDetail_Id);
            
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 70, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OutputDocuments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IssueDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OutputDocumentDesserts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Dessert_Id = c.Int(),
                        OutputDocument_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Desserts", t => t.Dessert_Id)
                .ForeignKey("dbo.OutputDocuments", t => t.OutputDocument_Id)
                .Index(t => t.Dessert_Id)
                .Index(t => t.OutputDocument_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OutputDocumentDesserts", "OutputDocument_Id", "dbo.OutputDocuments");
            DropForeignKey("dbo.OutputDocumentDesserts", "Dessert_Id", "dbo.Desserts");
            DropForeignKey("dbo.InputDocumentProducts", "Provider_Id", "dbo.Providers");
            DropForeignKey("dbo.InputDocumentProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Products", "ProductDetail_Id", "dbo.ProductDetails");
            DropForeignKey("dbo.InputDocumentProducts", "InputDocument_Id", "dbo.InputDocuments");
            DropForeignKey("dbo.ProductDetailDesserts", "ProductDetail_Id", "dbo.ProductDetails");
            DropForeignKey("dbo.ProductDetailDesserts", "Dessert_Id", "dbo.Desserts");
            DropIndex("dbo.OutputDocumentDesserts", new[] { "OutputDocument_Id" });
            DropIndex("dbo.OutputDocumentDesserts", new[] { "Dessert_Id" });
            DropIndex("dbo.Products", new[] { "ProductDetail_Id" });
            DropIndex("dbo.InputDocumentProducts", new[] { "Provider_Id" });
            DropIndex("dbo.InputDocumentProducts", new[] { "Product_Id" });
            DropIndex("dbo.InputDocumentProducts", new[] { "InputDocument_Id" });
            DropIndex("dbo.ProductDetailDesserts", new[] { "ProductDetail_Id" });
            DropIndex("dbo.ProductDetailDesserts", new[] { "Dessert_Id" });
            DropTable("dbo.OutputDocumentDesserts");
            DropTable("dbo.OutputDocuments");
            DropTable("dbo.Providers");
            DropTable("dbo.Products");
            DropTable("dbo.InputDocumentProducts");
            DropTable("dbo.InputDocuments");
            DropTable("dbo.ProductDetails");
            DropTable("dbo.ProductDetailDesserts");
            DropTable("dbo.Desserts");
        }
    }
}
