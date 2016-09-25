using System.ComponentModel.DataAnnotations;

namespace PastryShopProductManagementSystem.Models
{
    public class RecipeLine
    {
        [Key]
        public int Id { get; set; }

        public ProductDetail ProductDetail { get; set; }

        public Recipe Recipe { get; set; }

        public decimal Quantity { get; set; }
    }
}
