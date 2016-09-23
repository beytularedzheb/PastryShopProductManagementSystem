using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastryShopProductManagementSystem.Models
{
    public class OutputDocument
    {

        public OutputDocument()
        {
            this.OutputDocsDesserts = new HashSet<OutputDocumentDessert>();
        }

        [Key]
        public int Id { get; set; }

        public DateTime IssueDate { get; set; }

        public virtual ICollection<OutputDocumentDessert> OutputDocsDesserts { get; set; }

    }
}
