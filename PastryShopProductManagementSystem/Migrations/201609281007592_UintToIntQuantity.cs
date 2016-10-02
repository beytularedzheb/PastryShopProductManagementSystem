namespace PastryShopProductManagementSystem.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class UintToIntQuantity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OutputDocumentLines", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OutputDocumentLines", "Quantity");
        }
    }
}
