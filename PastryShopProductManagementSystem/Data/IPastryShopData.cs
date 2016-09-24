using PastryShopProductManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastryShopProductManagementSystem.Data
{
    public interface IPastryShopData
    {
        DbContext Context { get; }
        IRepository<Dessert> Desserts { get; }
        IRepository<Provider> Providers { get; }
        IRepository<InputDocument> InputDocuments { get; }
        IRepository<InputDocumentProduct> InputDocumentsProducts { get; }
        IRepository<OutputDocument> OutputDocuments { get; }
        IRepository<OutputDocumentDessert> OutputDocumentsDesserts { get; }
        IRepository<Product> Products { get; }
        IRepository<ProductDetail> ProductDetails { get; }
        IRepository<ProductDetailDessert> ProductDetailsDesserts { get; }
        void Dispose();
        int SaveChanges();
    }
}
