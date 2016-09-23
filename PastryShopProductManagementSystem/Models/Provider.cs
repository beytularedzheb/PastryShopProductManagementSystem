using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastryShopProductManagementSystem.Models
{
    public class Provider
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(70)]
        public string Name { get; set; }
    }
}
