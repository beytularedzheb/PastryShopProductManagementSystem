using System.ComponentModel.DataAnnotations;

namespace PastryShopProductManagementSystem.Models
{
    public class ProductDetail
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(10)]
        public string Unit { get; set; }
    }
}
