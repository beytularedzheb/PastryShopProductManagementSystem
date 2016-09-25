﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PastryShopProductManagementSystem.Models
{
    public class InputDocument
    {
        public InputDocument()
        {
            this.Lines = new HashSet<InputDocumentLine>();
        }

        [Key]
        public int Id { get; set; }

        public virtual ICollection<InputDocumentLine> Lines { get; set; }
    }
}
