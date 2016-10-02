namespace PastryShopProductManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewEntityOutputDocProd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OutputDocLineProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CalcualtedQuantity = c.Double(nullable: false),
                        OutputDocLine_Id = c.Int(),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OutputDocumentLines", t => t.OutputDocLine_Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.OutputDocLine_Id)
                .Index(t => t.Product_Id);
            
            AddColumn("dbo.InputDocuments", "CreatedOn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OutputDocLineProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.OutputDocLineProducts", "OutputDocLine_Id", "dbo.OutputDocumentLines");
            DropIndex("dbo.OutputDocLineProducts", new[] { "Product_Id" });
            DropIndex("dbo.OutputDocLineProducts", new[] { "OutputDocLine_Id" });
            DropColumn("dbo.InputDocuments", "CreatedOn");
            DropTable("dbo.OutputDocLineProducts");
        }
    }
}
