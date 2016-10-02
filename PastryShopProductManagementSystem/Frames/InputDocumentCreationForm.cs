using PastryShopProductManagementSystem.CustomControls;
using PastryShopProductManagementSystem.Data;
using PastryShopProductManagementSystem.Frames.Helpers;
using PastryShopProductManagementSystem.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PastryShopProductManagementSystem.Frames
{
    public partial class InputDocumentCreationForm : Form
    {
        private IRepository<Provider> providerRepository;

        public InputDocumentCreationForm()
        {
            InitializeComponent();

            DataGridViewComboBoxColumn providerColumn = (DataGridViewComboBoxColumn)this.dgwInputDocument.Columns["Provider"];
            DataGridViewComboBoxColumn productColumn = (DataGridViewComboBoxColumn)this.dgwInputDocument.Columns["Product"];

            using (var db = new PastryShopDbContext())
            {
                providerColumn.DataSource = db.Providers.ToArray();
                providerColumn.DisplayMember = "Name";
                providerColumn.ValueMember = "Id";

                productColumn.DataSource = db.ProductDetails.ToArray();
                productColumn.DisplayMember = "Name";
                productColumn.ValueMember = "Id";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InputDocument inputDocument = InputDocumentMapper.ReadValues(this.dgwInputDocument, true);
            if (inputDocument != null)
            {
                this.dgwInputDocument.Rows.Clear();
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Не сте попълнили задължителните полета!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgwInputDocument_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void InputDocumentCreationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.dgwInputDocument.RowCount > 1)
            {
                var confirmResult = MessageBox.Show(this, "Има добавени продукти! Да се игнорират ли?",
                                     "Потвърждаване",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                e.Cancel = (confirmResult == DialogResult.No);
            }
        }
    }
}
