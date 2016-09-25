using System.ComponentModel.DataAnnotations;

namespace PastryShopProductManagementSystem.Models
{
    public class OutputDocumentLine
    {
        [Key]
        public int Id { get; set; }

        public Dessert Dessert { get; set; }

        public OutputDocument OutputDocument { get; set; }

        public int Quantity { get; set; }
    }
}
