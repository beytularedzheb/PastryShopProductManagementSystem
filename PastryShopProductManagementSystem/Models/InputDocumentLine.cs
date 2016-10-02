namespace PastryShopProductManagementSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class InputDocumentLine
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime ReceivingDate { get; set; }

        [Required, Range(0, Double.MaxValue)]
        public double ReceivedQuantity { get; set; }

        [MaxLength(20)]
        public string Vehicle { get; set; }

        [MaxLength(40)]
        public string Document { get; set; }

        [Required]
        public Product Product { get; set; }

        [Required]
        public Provider Provider { get; set; }

        [Required]
        public InputDocument InputDocument { get; set; }
    }
}
