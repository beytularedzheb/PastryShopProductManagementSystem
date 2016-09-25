using PastryShopProductManagementSystem.Data;
using PastryShopProductManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastryShopProductManagementSystem
{
    public partial class CreateDocumentFrame : Form
    {
        public CreateDocumentFrame()
        {
            InitializeComponent();
        }

        private void CreateDocumentFrame_Load(object sender, EventArgs e)
        {
            using (var db = new PastryShopDbContext())
            {
                this.dessertsComboBox.DataSource = db.Desserts.ToArray();
                this.dessertsComboBox.DisplayMember = "Name";
                this.dessertsComboBox.ValueMember = "Id";
            }
    }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var dessertName = this.dessertsComboBox.Text;
            var quantity = this.quantityTextBox.Text;
            ListViewItem item = new ListViewItem(dessertName);
            item.SubItems.Add(quantity);
            this.dessertListView.Items.Add(item);
        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            if (this.dessertListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in this.dessertListView.SelectedItems)
                {
                    item.Remove();
                }
            }
        }

    }
}
