using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastryShopProductManagementSystem.Models
{
    public class InputDocumentProduct
    {
        [Key]
        public int Id { get; set; }

        public DateTime ReceivingDate { get; set; }

        public decimal ReceivedQuantity { get; set; }

        [MaxLength(10)]
        public string Vehicle { get; set; }

        [MaxLength(40)]
        public string Document { get; set; }

        public Product Product { get; set; }

        public Provider Provider { get; set; }

        public InputDocument InputDocument { get; set; }
    }
}
