using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PastryShopProductManagementSystem.Models;

namespace PastryShopProductManagementSystem.DocumentTemplate
{
    public class DocumentModel
    {
        public List<string> Products { get; set; }
        public List<DessertInfo> Desserts { get; set; }
    }
}
