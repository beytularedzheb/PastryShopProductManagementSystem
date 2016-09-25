using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PastryShopProductManagementSystem.Models
{
    public class OutputDocument
    {

        public OutputDocument()
        {
            this.Lines = new HashSet<OutputDocumentLine>();
        }

        [Key]
        public int Id { get; set; }

        public DateTime IssueDate { get; set; }

        public virtual ICollection<OutputDocumentLine> Lines { get; set; }

    }
}
