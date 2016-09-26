using PastryShopProductManagementSystem.Data;
using PastryShopProductManagementSystem.DocumentTemplate;
using PastryShopProductManagementSystem.Models;
using RazorEngine;
using RazorEngine.Templating;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastryShopProductManagementSystem.Frames
{
    public partial class CreateDocumentFrame : Form
    {
        public CreateDocumentFrame()
        {
            InitializeComponent();
            DataGridViewComboBoxColumn dessertColumn = (DataGridViewComboBoxColumn)this.dessertDataGridView.Columns["Product"];
            DataGridViewButtonColumn deleteColumn = (DataGridViewButtonColumn)this.dessertDataGridView.Columns["Delete"];


            using (var db = new PastryShopDbContext())
            {
                dessertColumn.DataSource = db.Desserts.ToList();
                dessertColumn.DisplayMember = "Name";
                dessertColumn.ValueMember = "Id";
            }

        }
        private void dessertDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex].Name == "Delete"
                && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn
                && !senderGrid.Rows[e.RowIndex].IsNewRow)
            {
                this.dessertDataGridView.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dessertDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(QuantityColumn_KeyPress);
            if (this.dessertDataGridView.CurrentCell.ColumnIndex == 1)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(QuantityColumn_KeyPress);
                }
            }
        }

        private void QuantityColumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //private void dessertDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        //{
        //    int quantityCellIndex = this.dessertDataGridView.Columns["Quantity"].Index;
            
        //    if (this.dessertDataGridView.Rows[e.RowIndex].Cells[quantityCellIndex].Value == null)
        //    {
        //        MessageBox.Show("Полето за количество не може да бъде празно");
        //        e.Cancel = true;
        //    }

        //    int productCellIndex = this.dessertDataGridView.Columns["Product"].Index;

        //    if (this.dessertDataGridView.Rows[e.RowIndex].Cells[productCellIndex].Value == null)
        //    {
        //        MessageBox.Show("Полето за продукт не може да бъде празно");
        //        e.Cancel = true;
        //    }
        //}

        private void createDocButton_Click(object sender, EventArgs e)
        {
            
            if (!this.GridViewIsValid())
            {
                MessageBox.Show("Задължителните полета не са попълнени !");
                return;
            }

            if (this.dessertDataGridView.RowCount < 2)
            {
                MessageBox.Show("Таблицата за продукти е празна !");
                return;
            }

            var idsToQuantities = new Dictionary<int,int>();

            for (int i = 0; i < this.dessertDataGridView.RowCount-1; i++)
            {
                var id = int.Parse(this.dessertDataGridView.Rows[i].Cells["Product"].Value.ToString());
                var quantity = int.Parse(this.dessertDataGridView.Rows[i].Cells["Quantity"].Value.ToString());
                idsToQuantities.Add(id, quantity);
            }

            DocumentModel docModel = this.CreateDocumentModel(idsToQuantities);
            this.CreatePdfDocumet(docModel);
        }

        private bool GridViewIsValid()
        {
            int productColumnIndex = this.dessertDataGridView.Columns["Product"].Index;
            int quantityColumnIndex = this.dessertDataGridView.Columns["Quantity"].Index;

            for (int i = 0; i < this.dessertDataGridView.Rows.Count - 1; i++)
            {
                bool productCellValueIsNull = this.dessertDataGridView.Rows[i].Cells["Product"].Value==null;
                bool quantityCellValueIsNull = this.dessertDataGridView.Rows[i].Cells["Quantity"].Value==null;
                
                if (productCellValueIsNull || quantityCellValueIsNull)
                {
                    return false;
                }
            }
            return true;
        }

        private DocumentModel CreateDocumentModel(Dictionary<int, int> idsToQuantities)
        {
            PastryShopDbContext db = new PastryShopDbContext();

            DocumentModel docModel = new DocumentModel();
            using (db)
            {
                
                foreach (var item in idsToQuantities)
                {
                    var producDetails = from p in db.Products
                             join pd in db.ProductDetails on p.ProductDetail.Id equals pd.Id
                             select new { Id = pd.Id, Name = pd.Name , BatchNumber = p.BatchNumber };

                    var dessert = db.Desserts.FirstOrDefault(d => d.Id == item.Key);

                    docModel.Products = producDetails.Select(x => x.Name).ToList();
                    DessertInfo dessertInfo = new DessertInfo();
                    dessertInfo.Name = dessert.Name;
                    dessertInfo.Quantity = item.Value;

                    foreach (var line in dessert.Recipe.RecipeLines)
                    {
                        var productDetail = producDetails.FirstOrDefault(x => x.Id == line.Id);
                        Ingredient ingredient = new Ingredient();
                        ingredient.Name = productDetail.Name;
                        ingredient.BatchNumber = productDetail.BatchNumber;
                        ingredient.Quantity = item.Value * line.Quantity;
                    }

                }
            }

            return docModel;
        }

        private void CreatePdfDocumet(DocumentModel docModel)
        {

            string path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            var templatePath = path + @"\DocumentTemplate\Document.cshtml";
            string template = File.ReadAllText(templatePath);
            string htmlAsString = Engine.Razor.RunCompile(template, "key", typeof(DocumentModel), docModel, null);

            HtmlToPdf converter = new HtmlToPdf();
            // create a new pdf document converting the html string of the page
            converter.Options.PdfPageOrientation = PdfPageOrientation.Landscape;
            PdfDocument doc = converter.ConvertHtmlString(htmlAsString);
            // save pdf document
            doc.Save("Neww.pdf");

            // close pdf document
            doc.Close();
        }
    }
}
