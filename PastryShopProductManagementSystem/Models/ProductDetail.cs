using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastryShopProductManagementSystem.Models
{
    public class ProductDetail
    {

        public ProductDetail()
        {
            this.ProductDetailsDesserts = new HashSet<ProductDetailDessert>();
        }

        [Key]
        public int Id { get; set; }
        
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(10)]
        public string Unit { get; set; }

        public ICollection<ProductDetailDessert> ProductDetailsDesserts { get; set; }

    }
}
