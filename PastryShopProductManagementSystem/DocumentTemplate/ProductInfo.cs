using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastryShopProductManagementSystem.DocumentTemplate
{
    public class ProductInfo
    {
        public string Name { get; set; }

        public static List<ProductInfo> GetProducts()
        {
            List<ProductInfo> p = new List<ProductInfo>();
            for (int i = 0; i < 14; i++)
            {
                p.Add(new ProductInfo { Name = "product" + i });
            }
            return p;
        }
    }
}