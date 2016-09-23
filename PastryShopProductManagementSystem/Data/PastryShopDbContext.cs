using PastryShopProductManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastryShopProductManagementSystem.Data
{
    public class PastryShopDbContext : DbContext
    {

        public PastryShopDbContext() : base("DefaultConnection")
        {

        }
        public DbSet<Dessert> Desserts { get; set; }
        public DbSet<InputDocument> InputDocuments { get; set; }
        public DbSet<InputDocumentProduct> InputDocumentsProducts { get; set; }
        public DbSet<OutputDocument> OutputDocuments { get; set; }
        public DbSet<OutputDocumentDessert> OutputDocumentsDesserts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ProductDetailDessert> ProductDetailsDesserts { get; set; }
    }
}
