using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastryShopProductManagementSystem.DocumentTemplate
{
    public class DessertInfo
    {

        public DessertInfo()
        {
            this.Ingredients = new List<Ingredient>();
        }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public static List<DessertInfo> GetProducts()
        {
            List<DessertInfo> p = new List<DessertInfo>();
            for (int i = 0; i < 14; i++)
            {
                p.Add(new DessertInfo { Name = "product" + i });
            }
            return p;
        }
    }
}