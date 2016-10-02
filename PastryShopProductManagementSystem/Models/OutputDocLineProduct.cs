namespace PastryShopProductManagementSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class OutputDocLineProduct
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public double CalcualtedQuantity { get; set; }

        public OutputDocumentLine OutputDocLine { get; set; }

        public Product Product { get; set; }
    }
}
