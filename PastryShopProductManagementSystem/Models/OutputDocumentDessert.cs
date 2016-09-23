using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastryShopProductManagementSystem.Models
{
    public class OutputDocumentDessert
    {
        [Key]
        public int Id { get; set; }

        public Dessert Dessert { get; set; }

        public OutputDocument OutputDocument { get; set; }

        public decimal Quantity { get; set; }
    }
}
