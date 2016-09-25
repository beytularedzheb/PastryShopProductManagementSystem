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
                    Name = c.String(nullable: false, maxLength: 50, unicode: false),
                    Recipe_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Recipes", t => t.Recipe_Id)
                .Index(t => t.Recipe_Id);

            CreateTable(
                "dbo.Recipes",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.RecipeLines",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Quantity = c.Decimal(nullable: false, precision: 16, scale: 6),
                    Recipe_Id = c.Int(),
                    ProductDetail_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Recipes", t => t.Recipe_Id)
                .ForeignKey("dbo.ProductDetails", t => t.ProductDetail_Id)
                .Index(t => t.Recipe_Id)
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
                "dbo.InputDocumentLines",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    ReceivingDate = c.DateTime(nullable: false),
                    ReceivedQuantity = c.Int(nullable: false),
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
                    AvailableQuantity = c.Decimal(nullable: false, precision: 16, scale: 6),
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
                    Name = c.String(nullable: false, maxLength: 70, unicode: false),
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
                "dbo.OutputDocumentLines",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Quantity = c.Decimal(nullable: false, precision: 16, scale: 6),
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
            DropForeignKey("dbo.OutputDocumentLines", "OutputDocument_Id", "dbo.OutputDocuments");
            DropForeignKey("dbo.OutputDocumentLines", "Dessert_Id", "dbo.Desserts");
            DropForeignKey("dbo.InputDocumentLines", "Provider_Id", "dbo.Providers");
            DropForeignKey("dbo.InputDocumentLines", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Products", "ProductDetail_Id", "dbo.ProductDetails");
            DropForeignKey("dbo.InputDocumentLines", "InputDocument_Id", "dbo.InputDocuments");
            DropForeignKey("dbo.RecipeLines", "ProductDetail_Id", "dbo.ProductDetails");
            DropForeignKey("dbo.RecipeLines", "Recipe_Id", "dbo.Recipes");
            DropForeignKey("dbo.Desserts", "Recipe_Id", "dbo.Recipes");

            DropIndex("dbo.OutputDocumentLines", new[] { "OutputDocument_Id" });
            DropIndex("dbo.OutputDocumentLines", new[] { "Dessert_Id" });
            DropIndex("dbo.Products", new[] { "ProductDetail_Id" });
            DropIndex("dbo.InputDocumentLines", new[] { "Provider_Id" });
            DropIndex("dbo.InputDocumentLines", new[] { "Product_Id" });
            DropIndex("dbo.InputDocumentLines", new[] { "InputDocument_Id" });
            DropIndex("dbo.RecipeLines", new[] { "ProductDetail_Id" });
            DropIndex("dbo.RecipeLines", new[] { "Recipe_Id" });
            DropIndex("dbo.Desserts", new[] { "Recipe_Id" });

            DropTable("dbo.OutputDocumentLines");
            DropTable("dbo.OutputDocuments");
            DropTable("dbo.Providers");
            DropTable("dbo.Products");
            DropTable("dbo.InputDocumentLines");
            DropTable("dbo.InputDocuments");
            DropTable("dbo.ProductDetails");
            DropTable("dbo.RecipeLines");
            DropTable("dbo.Recipes");
            DropTable("dbo.Desserts");
        }
    }
}
