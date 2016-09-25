using PastryShopProductManagementSystem.Frames;
using System;
using System.Windows.Forms;

namespace PastryShopProductManagementSystem
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void btnNewInputDoc_Click(object sender, EventArgs e)
        {
            InputDocumentCreationForm inputDocumentCreationForm = new InputDocumentCreationForm();
            inputDocumentCreationForm.ShowDialog(this);
        }
    }
}
