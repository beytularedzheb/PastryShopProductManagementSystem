using PastryShopProductManagementSystem.Models;
using System.Data.Entity;

namespace PastryShopProductManagementSystem.Data
{
    public class PastryShopDbContext : DbContext
    {

        public PastryShopDbContext() : base("PastryDbContext")
        {
        }

        public DbSet<Dessert> Desserts { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<InputDocument> InputDocuments { get; set; }
        public DbSet<InputDocumentLine> InputDocumentLines { get; set; }
        public DbSet<OutputDocument> OutputDocuments { get; set; }
        public DbSet<OutputDocumentLine> OutputDocumentLines { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeLine> RecipeLines { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<PastryShopDbContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
