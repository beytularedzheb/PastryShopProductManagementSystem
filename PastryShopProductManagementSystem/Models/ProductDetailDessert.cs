using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastryShopProductManagementSystem.Models
{
    public class ProductDetailDessert
    {
        [Key]
        public int Id { get; set; }

        public ProductDetail ProductDetail { get; set; }

        public Dessert Dessert { get; set; }

        public decimal Quantity { get; set; }
    }
}
