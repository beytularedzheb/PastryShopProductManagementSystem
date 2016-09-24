namespace PastryShopProductManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DecimalPecision : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductDetailDesserts", "Quantity", c => c.Decimal(nullable: false, precision: 16, scale: 6));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductDetailDesserts", "Quantity", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
