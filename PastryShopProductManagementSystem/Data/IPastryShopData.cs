namespace PastryShopProductManagementSystem.Data
{
    using Models;
    using System.Data.Entity;

    public interface IPastryShopData
    {
        DbContext Context { get; }
        IRepository<Dessert> Desserts { get; }
        IRepository<Provider> Providers { get; }
        IRepository<InputDocument> InputDocuments { get; }
        IRepository<InputDocumentLine> InputDocumentLines { get; }
        IRepository<OutputDocument> OutputDocuments { get; }
        IRepository<OutputDocumentLine> OutputDocumentLines { get; }
        IRepository<Product> Products { get; }
        IRepository<ProductDetail> ProductDetails { get; }
        IRepository<RecipeLine> RecipeLines { get; }
        void Dispose();
        int SaveChanges();
    }
}
