using PastryShopProductManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastryShopProductManagementSystem.Data
{
    public class PastryShopData : IPastryShopData
    {
        private readonly DbContext context;

        private readonly Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public PastryShopData(DbContext context)
        {
            this.context = context;
        }

        public IRepository<Dessert> Desserts
        {
            get { return this.GetRepository<Dessert>(); }
        }

        public IRepository<Provider> Providers
        {
            get { return this.GetRepository<Provider>(); }
        }

        public IRepository<InputDocument> InputDocuments
        {
            get { return this.GetRepository<InputDocument>(); }
        }

        public IRepository<InputDocumentProduct> InputDocumentsProducts
        {
            get { return this.GetRepository<InputDocumentProduct>(); }
        }

        public IRepository<OutputDocument> OutputDocuments
        {
            get { return this.GetRepository<OutputDocument>(); }
        }

        public IRepository<OutputDocumentDessert> OutputDocumentsDesserts
        {
            get { return this.GetRepository<OutputDocumentDessert>(); }
        }

        public IRepository<Product> Products
        {
            get { return this.GetRepository<Product>(); }
        }

        public IRepository<ProductDetail> ProductDetails
        {
            get { return this.GetRepository<ProductDetail>(); }
        }

        public IRepository<ProductDetailDessert> ProductDetailsDesserts
        {
            get { return this.GetRepository<ProductDetailDessert>(); }
        }

        public void Dispose()
        {
            this.context.Dispose();
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(GenericRepository<T>);

                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.context));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }

        public DbContext Context
        {
            get { return this.context; }
        }
    }
}
