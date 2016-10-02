namespace PastryShopProductManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class OutputDocument
    {
        public OutputDocument()
        {
            this.Lines = new HashSet<OutputDocumentLine>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime IssueDate { get; set; }

        public virtual ICollection<OutputDocumentLine> Lines { get; set; }
    }
}
