namespace PastryShopProductManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class InputDocument
    {
        public InputDocument()
        {
            this.Lines = new HashSet<InputDocumentLine>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<InputDocumentLine> Lines { get; set; }
    }
}
