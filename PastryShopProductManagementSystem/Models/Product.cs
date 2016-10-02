namespace PastryShopProductManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {

        public Product()
        {
            this.OutputDocLineProducts = new HashSet<OutputDocLineProduct>();
        }

        [Key]
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string BatchNumber { get; set; }

        [Required, Range(0, Double.MaxValue)]
        public double AvailableQuantity { get; set; }

        [MaxLength(80)]
        public string StorageCondition { get; set; }

        [Required]
        public DateTime ExpiryDate { get; set; }

        [Required]
        public ProductDetail ProductDetail { get; set; }

        public virtual ICollection<OutputDocLineProduct> OutputDocLineProducts { get; set; }

    }
}
