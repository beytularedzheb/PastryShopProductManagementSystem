using PastryShopProductManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

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

        public IRepository<InputDocumentLine> InputDocumentLines
        {
            get { return this.GetRepository<InputDocumentLine>(); }
        }

        public IRepository<OutputDocument> OutputDocuments
        {
            get { return this.GetRepository<OutputDocument>(); }
        }

        public IRepository<OutputDocumentLine> OutputDocumentLines
        {
            get { return this.GetRepository<OutputDocumentLine>(); }
        }

        public IRepository<Product> Products
        {
            get { return this.GetRepository<Product>(); }
        }

        public IRepository<ProductDetail> ProductDetails
        {
            get { return this.GetRepository<ProductDetail>(); }
        }
        public IRepository<Recipe> Recipes
        {
            get { return this.GetRepository<Recipe>(); }
        }

        public IRepository<RecipeLine> RecipeLines
        {
            get { return this.GetRepository<RecipeLine>(); }
        }

        public DbContext Context
        {
            get{ return this.context; }
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
