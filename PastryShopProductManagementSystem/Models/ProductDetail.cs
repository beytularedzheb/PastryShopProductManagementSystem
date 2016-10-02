namespace PastryShopProductManagementSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ProductDetail
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [MaxLength(10)]
        public string Unit { get; set; }
    }
}
