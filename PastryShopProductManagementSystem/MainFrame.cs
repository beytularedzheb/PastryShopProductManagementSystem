﻿using PastryShopProductManagementSystem.Frames;
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
            InputDocumentCreationFrame inputDocumentCreationForm = new InputDocumentCreationFrame();
            inputDocumentCreationForm.ShowDialog(this);
        }

        private void btnNewOutputDoc_Click(object sender, EventArgs e)
        {
            var createOutputDocForm = new CreateDocumentFrame();
            createOutputDocForm.ShowDialog(this);
        }
    }
}
