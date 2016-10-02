namespace PastryShopProductManagementSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class RecipeLine
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public virtual ProductDetail ProductDetail { get; set; }

        [Required]
        public Dessert Dessert { get; set; }

        [Required, Range(0, Double.MaxValue)]
        public double Quantity { get; set; }
    }
}
