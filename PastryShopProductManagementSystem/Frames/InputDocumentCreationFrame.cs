﻿namespace PastryShopProductManagementSystem.Frames
{
    using Data;
    using Helpers;
    using Models;
    using System;
    using System.Linq;
    using System.Windows.Forms;

    public partial class InputDocumentCreationFrame : Form
    {
        public InputDocumentCreationFrame()
        {
            InitializeComponent();

            DataGridViewComboBoxColumn providerColumn = (DataGridViewComboBoxColumn)this.dgwInputDocument.Columns["Provider"];
            DataGridViewComboBoxColumn productColumn = (DataGridViewComboBoxColumn)this.dgwInputDocument.Columns["Product"];

            Cursor = Cursors.WaitCursor;
            using (var db = new PastryShopDbContext())
            {
                providerColumn.DataSource = db.Providers.OrderBy(pr => pr.Name).ToList();
                providerColumn.DisplayMember = "Name";
                providerColumn.ValueMember = "Id";

                productColumn.DataSource = db.ProductDetails.OrderBy(pd => pd.Name).ToList();
                productColumn.DisplayMember = "Name";
                productColumn.ValueMember = "Id";
            }
            Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string message = String.Empty;
            if (this.dgwInputDocument != null && this.dgwInputDocument.RowCount > 1)
            {
                var dlgResult = MessageBox.Show(this, "Сигурни ли сте, че искате да запишетe данните!", "",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {
                    InputDocument inputDocument = InputDocumentMapper.ReadValues(this.dgwInputDocument, true);
                    if (inputDocument != null)
                    {
                        this.dgwInputDocument.Rows.Clear();
                        this.Close();
                    }
                    else
                    {
                        message = "Не сте попълнили задължителните полета!";
                    }
                }
            }
            else
            {
                message = "Няма добавени продукти!";
            }
            if (message != String.Empty)
            {
                MessageBox.Show(this, message, "",
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
