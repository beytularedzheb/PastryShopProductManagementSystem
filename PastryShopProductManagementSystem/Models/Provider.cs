namespace PastryShopProductManagementSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Provider
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
