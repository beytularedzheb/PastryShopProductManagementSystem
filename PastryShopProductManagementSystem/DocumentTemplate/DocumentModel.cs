namespace PastryShopProductManagementSystem.DocumentTemplate
{
    using Data;
    using Models;
    using System;
    using System.Collections.Generic;

    public class DocumentModel
    {
        public DocumentModel()
        {
            this.Desserts = new List<DessertInfo>();
        }
        public List<DessertInfo> Desserts { get; set; }

        public DateTime IssueDate { get; set; }
    }
}
