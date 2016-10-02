namespace PastryShopProductManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class OutputDocumentLine
    {

        public OutputDocumentLine()
        {
            this.OutputDocLineProducts = new HashSet<OutputDocLineProduct>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public Dessert Dessert { get; set; }

        [Required]
        public OutputDocument OutputDocument { get; set; }

        [Required, Range(0, Int32.MaxValue)]
        public int Quantity { get; set; }

        public virtual ICollection<OutputDocLineProduct> OutputDocLineProducts { get; set; }
    }
}
