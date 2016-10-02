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

    public partial class CreateDocumentFrame : Form
    {
        public CreateDocumentFrame()
        {
            InitializeComponent();

            DataGridViewComboBoxColumn dessertColumn = (DataGridViewComboBoxColumn)this.dessertDataGridView.Columns["Product"];
            DataGridViewButtonColumn deleteColumn = (DataGridViewButtonColumn)this.dessertDataGridView.Columns["Delete"];

            Cursor = Cursors.WaitCursor;
            using (var db = new PastryShopDbContext())
            {
                dessertColumn.DataSource = db.Desserts.OrderBy(d => d.Name).ToList();
                dessertColumn.DisplayMember = "Name";
                dessertColumn.ValueMember = "Id";
            }
            Cursor = Cursors.Default;
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
        private void createDocButton_Click(object sender, EventArgs e)
        {

            if (!this.GridViewIsFilled())
            {
                MessageBox.Show(this, "Задължителните полета не са попълнени!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.dessertDataGridView.RowCount < 2)
            {
                MessageBox.Show(this, "Таблицата за продукти е празна!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var idsToQuantities = new Dictionary<int, int>();
            OutputDocumentLine ol = new OutputDocumentLine();

            for (int i = 0; i < this.dessertDataGridView.RowCount - 1; i++)
            {
                var id = int.Parse(this.dessertDataGridView.Rows[i].Cells["Product"].Value.ToString());
                var quantity = int.Parse(this.dessertDataGridView.Rows[i].Cells["Quantity"].Value.ToString());
                if (idsToQuantities.Keys.Contains(id))
                {
                    MessageBox.Show(this, "Има повтарящи се продукти", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                idsToQuantities.Add(id, quantity);
            }

            var dlgResult = MessageBox.Show(this, "Сигурни ли сте, че искате да запишетe документа!", "",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgResult == DialogResult.Yes)
            {
                try
                {
                    DocumentModel docModel = this.CreateDocumentModel(idsToQuantities);
                    PdfMaker pdfMaker = new PdfMaker();
                    pdfMaker.CreatePdfDocumet(docModel);
                    this.dessertDataGridView.Rows.Clear();
                    this.Close();
                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool GridViewIsFilled()
        {
            int productColumnIndex = this.dessertDataGridView.Columns["Product"].Index;
            int quantityColumnIndex = this.dessertDataGridView.Columns["Quantity"].Index;

            for (int i = 0; i < this.dessertDataGridView.Rows.Count - 1; i++)
            {
                bool productCellValueIsNull = this.dessertDataGridView.Rows[i].Cells["Product"].Value == null;
                bool quantityCellValueIsNull = this.dessertDataGridView.Rows[i].Cells["Quantity"].Value == null;

                if (productCellValueIsNull || quantityCellValueIsNull)
                {
                    return false;
                }
            }
            return true;
        }

        private DocumentModel CreateDocumentModel(Dictionary<int, int> idsToQuantities)
        {
            Cursor = Cursors.WaitCursor;
            DocumentModel docModel = new DocumentModel();
            docModel.IssueDate = DateTime.Now;
            //Saving OutputDocument
            OutputDocument outputDoc = new OutputDocument();
            outputDoc.IssueDate = DateTime.Now.Date;

            using (var db = new PastryShopDbContext())
            {
                using (var tr = db.Database.BeginTransaction())
                {
                    foreach (var item in idsToQuantities)
                    {
                        Dessert dessert = db.Desserts.Include("RecipeLines.ProductDetail").FirstOrDefault(d => d.Id == item.Key);

                        DessertInfo dessertInfo = new DessertInfo();
                        dessertInfo.Name = dessert.Name;
                        dessertInfo.Quantity = item.Value;

                        //Saving OutputDocument
                        OutputDocumentLine outputDocLine = new OutputDocumentLine();
                        outputDocLine.Quantity = item.Value;
                        outputDocLine.Dessert = dessert;
                        outputDocLine.OutputDocument = outputDoc;

                        foreach (var recipeLine in dessert.RecipeLines)
                        {
                            var dateNow = DateTime.Now.Date;
                            var productsInStore = db.Products
                                .Where(p => p.ProductDetail.Id == recipeLine.ProductDetail.Id
                                    && p.AvailableQuantity > 0
                                    && p.ExpiryDate >= dateNow
                                );

                            int productsInStoreCount = productsInStore.Count();

                            double neededQuantity = item.Value * recipeLine.Quantity;
                            var productInDbSum = productsInStore.Sum(p => (double?)(p.AvailableQuantity)) ?? 0;

                            if (productsInStoreCount == 0 || productInDbSum < neededQuantity)
                            {
                                throw new Exception("Няма достатъчно количество " + recipeLine.ProductDetail.Name + " за " + dessert.Name);
                            }


                            while (neededQuantity > 0)
                            {
                                var product = productsInStore.FirstOrDefault(p => p.AvailableQuantity > 0 && p.ExpiryDate >= dateNow);

                                // product can be null if at the time of execution
                                // the query expiry date become < DateTime.Now.Date
                                if (product == null)
                                {
                                    throw new Exception("Няма достатъчно количество " + recipeLine.ProductDetail.Name + " за " + dessert.Name);
                                }
                                Ingredient ingredient = new Ingredient();
                                ingredient.Name = recipeLine.ProductDetail.Name;
                                ingredient.Unit = recipeLine.ProductDetail.Unit;
                                ingredient.BatchNumber = product.BatchNumber;

                                //Saving OutputDocument
                                OutputDocLineProduct outDocLine = new OutputDocLineProduct();
                                outDocLine.OutputDocLine = outputDocLine;
                                outDocLine.Product = product;

                                if (product.AvailableQuantity >= neededQuantity)
                                {
                                    product.AvailableQuantity -= neededQuantity;
                                    ingredient.Quantity = neededQuantity;
                                    outDocLine.CalcualtedQuantity = neededQuantity;
                                    neededQuantity = 0;
                                }
                                else
                                {
                                    neededQuantity -= product.AvailableQuantity;
                                    ingredient.Quantity = product.AvailableQuantity;
                                    product.AvailableQuantity = 0;
                                }

                                //Saving OutputDocument
                                outDocLine.CalcualtedQuantity = ingredient.Quantity;
                                outputDocLine.OutputDocLineProducts.Add(outDocLine);
                                dessertInfo.Ingredients.Add(ingredient);
                                db.SaveChanges();
                            }

                        }
                        outputDocLine.OutputDocument = outputDoc;
                        outputDoc.Lines.Add(outputDocLine);

                        docModel.Desserts.Add(dessertInfo);
                    }
                    db.OutputDocuments.Add(outputDoc);
                    db.SaveChanges();
                    tr.Commit();
                }
            }
            Cursor = Cursors.Default;

            return docModel;
        }

        private void CreateDocumentFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.dessertDataGridView.RowCount > 1)
            {
                var confirmResult = MessageBox.Show(this, "Има добавени продукти! Да се игнорират ли?",
                                     "Потвърждаване",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                e.Cancel = (confirmResult == DialogResult.No);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
