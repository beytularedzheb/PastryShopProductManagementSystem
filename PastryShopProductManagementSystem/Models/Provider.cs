using System.ComponentModel.DataAnnotations;

namespace PastryShopProductManagementSystem.Models
{
    public class Provider
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(70)]
        public string Name { get; set; }
    }
}
