namespace PastryShopProductManagementSystem.Frames
{
    using Data;
    using DocumentTemplate;
    using Helpers;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    public partial class ShowOutputDocumentsFrame : Form
    {
        public ShowOutputDocumentsFrame()
        {
            InitializeComponent();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var fromDate = fromDateTimePicker.Value.Date;
            var toDate = toDateTimePicker.Value.Date;

            List<OutputDocument> filtredDocuments = new List<OutputDocument>();

            using (var db = new PastryShopDbContext())
            {
                filtredDocuments = db.OutputDocuments.Where(d => d.IssueDate >= fromDate && d.IssueDate <= toDate).ToList();
            }
            this.outputDocGridView.Rows.Clear();
            for (int i = 0; i < filtredDocuments.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int rowIndex = this.outputDocGridView.Rows.Add();
                row = this.outputDocGridView.Rows[rowIndex];
                row.Cells["id"].Value = filtredDocuments[i].Id;
                row.Cells["issueDate"].Value = filtredDocuments[i].IssueDate.ToShortDateString();
            }
            Cursor = Cursors.Default;
        }

        private void outputDocGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using(var db = new PastryShopDbContext())
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex].Name == "show"
                    && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn
                    && !senderGrid.Rows[e.RowIndex].IsNewRow)
                {
                    var docId = int.Parse(senderGrid.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    var outputDoc = db.OutputDocuments
                        .Include("Lines.Dessert")
                        .Include("Lines.OutputDocLineProducts.Product.ProductDetail")
                        .FirstOrDefault(d => d.Id == docId);
                    
                    if (outputDoc != null)
	                {
                        PdfMaker pdfMaker = new PdfMaker();
                        DocumentModel docModel = DocumentModelMapper.CreateDocumentModel(outputDoc);
                        pdfMaker.CreatePdfDocumet(docModel);
	                }
                }
            }
            Cursor = Cursors.Default;
            
        }
    }
}
