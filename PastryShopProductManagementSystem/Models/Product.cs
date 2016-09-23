using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastryShopProductManagementSystem.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        public string  BatchNumber { get; set; }

        public decimal AvailableQuantity { get; set; }

        [MaxLength(80)]
        public string StorageCondition { get; set; }

        public DateTime ExpiryDate { get; set; }

        public ProductDetail ProductDetail { get; set; }
    }
}
