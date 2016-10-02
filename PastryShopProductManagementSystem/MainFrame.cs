namespace PastryShopProductManagementSystem
{
    using PastryShopProductManagementSystem.Frames;
    using System;
    using System.Windows.Forms;

    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void btnNewInputDoc_Click(object sender, EventArgs e)
        {
            InputDocumentCreationFrame inputDocumentCreationFrame = new InputDocumentCreationFrame();
            inputDocumentCreationFrame.ShowDialog(this);
        }

        private void btnNewOutputDoc_Click(object sender, EventArgs e)
        {
            CreateDocumentFrame createOutputDocFrame = new CreateDocumentFrame();
            createOutputDocFrame.ShowDialog(this);
        }

        private void addDessertToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddNewItemFrame addNewItemFrame = new AddNewItemFrame();
            addNewItemFrame.ShowDialog(this);
        }

        private void toolStripComboBoxProduct_Click(object sender, EventArgs e)
        {
            ItemVisualizerFrame itemVisualizerFrame = new ItemVisualizerFrame();
            itemVisualizerFrame.ShowDialog(this);
        }

        private void inputDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOutputDocumentsFrame outputDocFrame = new ShowOutputDocumentsFrame();
            outputDocFrame.Show(this);
        }
    }
}
