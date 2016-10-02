namespace PastryShopProductManagementSystem.Frames
{
    using Data;
    using Helpers;
    using Models;
    using System;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class AddNewItemFrame : Form
    {
        public AddNewItemFrame()
        {
            InitializeComponent();
            ReloadDataGrid();
        }

        private void ReloadDataGrid()
        {
            DataGridViewComboBoxColumn productColumn = (DataGridViewComboBoxColumn)this.dgwRecipe.Columns["Product"];

            Cursor = Cursors.WaitCursor;
            using (var db = new PastryShopDbContext())
            {
                productColumn.DataSource = db.ProductDetails.OrderBy(pd => pd.Name).ToList();
                productColumn.DisplayMember = "Name";
                productColumn.ValueMember = "Id";
            }
            Cursor = Cursors.Default;
            this.UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            this.dgwRecipe.Update();
            this.dgwRecipe.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string message = String.Empty;
            if (tabCtrlItems.SelectedIndex == 0)
            {

                Dessert dessert = DessertMapper.ReadValues(this.dgwRecipe, this.tbDessertName, true);
                if (dessert != null)
                {
                    this.tbDessertName.Clear();
                    this.dgwRecipe.Rows.Clear();
                    this.UpdateDataGrid();
                    message = String.Format("Изделието \"{0}\" е успешно добавено!", dessert.Name);
                }
                else
                {
                    message = "Не сте попълнили задължителните полета!";
                }
            }
            else if (tabCtrlItems.SelectedIndex == 1)
            {
                ProductDetail productDetail = ProductDetailMapper.ReadValues(this.tbProductName, this.tbProductUnit, true);
                if (productDetail != null)
                {
                    this.tbProductName.Clear();
                    this.tbProductUnit.Clear();
                    this.ReloadDataGrid();
                    message = String.Format("Продуктът \"{0}\" е успешно добавен!", productDetail.Name);
                }
                else
                {
                    message = "Не сте попълнили задължителните полета!";
                }
            }
            else if (tabCtrlItems.SelectedIndex == 2)
            {
                Provider provider = ProviderMapper.ReadValues(this.tbProviderName, true);
                if (provider != null)
                {
                    this.tbProviderName.Clear();
                    message = String.Format("Доставчикът \"{0}\" е успешно добавен!", provider.Name);
                }
                else
                {
                    message = "Не сте попълнили задължителните полета!";
                }
            }

            if (message != String.Empty)
            {
                MessageBox.Show(this, message, "", MessageBoxButtons.OK);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgwRecipe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex < senderGrid.RowCount - 1)
            {
                var confirmResult = MessageBox.Show("Сигурни ли сте, че искате да изтриете този ред?",
                     "Изтриване",
                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    senderGrid.Rows.RemoveAt(e.RowIndex);
                    senderGrid.Update();
                    senderGrid.Refresh();
                }
            }
        }
    }
}
