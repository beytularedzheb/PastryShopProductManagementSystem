namespace PastryShopProductManagementSystem
{
    partial class MainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dessertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDessertToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpMainFrame = new System.Windows.Forms.TableLayoutPanel();
            this.btnNewInputDoc = new System.Windows.Forms.Button();
            this.btnNewOutputDoc = new System.Windows.Forms.Button();
            this.menuStripMain.SuspendLayout();
            this.tlpMainFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentsToolStripMenuItem,
            this.dessertToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(628, 24);
            this.menuStripMain.TabIndex = 0;
            // 
            // documentsToolStripMenuItem
            // 
            this.documentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputDocToolStripMenuItem});
            this.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            this.documentsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.documentsToolStripMenuItem.Text = "Документи";
            // 
            // inputDocToolStripMenuItem
            // 
            this.inputDocToolStripMenuItem.Name = "inputDocToolStripMenuItem";
            this.inputDocToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.inputDocToolStripMenuItem.Text = "Вложени материали";
            this.inputDocToolStripMenuItem.Click += new System.EventHandler(this.inputDocToolStripMenuItem_Click);
            // 
            // dessertToolStripMenuItem
            // 
            this.dessertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDessertToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.toolStripComboBoxProduct});
            this.dessertToolStripMenuItem.Name = "dessertToolStripMenuItem";
            this.dessertToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.dessertToolStripMenuItem.Text = "Операции";
            // 
            // addDessertToolStripMenuItem1
            // 
            this.addDessertToolStripMenuItem1.Name = "addDessertToolStripMenuItem1";
            this.addDessertToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.addDessertToolStripMenuItem1.Text = "Добавяне";
            this.addDessertToolStripMenuItem1.Click += new System.EventHandler(this.addDessertToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 6);
            // 
            // toolStripComboBoxProduct
            // 
            this.toolStripComboBoxProduct.Name = "toolStripComboBoxProduct";
            this.toolStripComboBoxProduct.Size = new System.Drawing.Size(127, 22);
            this.toolStripComboBoxProduct.Text = "Продукти";
            this.toolStripComboBoxProduct.Click += new System.EventHandler(this.toolStripComboBoxProduct_Click);
            // 
            // tlpMainFrame
            // 
            this.tlpMainFrame.ColumnCount = 2;
            this.tlpMainFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainFrame.Controls.Add(this.btnNewInputDoc, 0, 0);
            this.tlpMainFrame.Controls.Add(this.btnNewOutputDoc, 1, 0);
            this.tlpMainFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainFrame.Location = new System.Drawing.Point(0, 24);
            this.tlpMainFrame.Name = "tlpMainFrame";
            this.tlpMainFrame.RowCount = 1;
            this.tlpMainFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainFrame.Size = new System.Drawing.Size(628, 278);
            this.tlpMainFrame.TabIndex = 1;
            // 
            // btnNewInputDoc
            // 
            this.btnNewInputDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewInputDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewInputDoc.Location = new System.Drawing.Point(3, 99);
            this.btnNewInputDoc.Name = "btnNewInputDoc";
            this.btnNewInputDoc.Size = new System.Drawing.Size(308, 80);
            this.btnNewInputDoc.TabIndex = 0;
            this.btnNewInputDoc.Text = "Нов документ за входящ контрол";
            this.btnNewInputDoc.UseVisualStyleBackColor = true;
            this.btnNewInputDoc.Click += new System.EventHandler(this.btnNewInputDoc_Click);
            // 
            // btnNewOutputDoc
            // 
            this.btnNewOutputDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewOutputDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewOutputDoc.Location = new System.Drawing.Point(317, 99);
            this.btnNewOutputDoc.Name = "btnNewOutputDoc";
            this.btnNewOutputDoc.Size = new System.Drawing.Size(308, 80);
            this.btnNewOutputDoc.TabIndex = 1;
            this.btnNewOutputDoc.Text = "Нов документ за вложени материали";
            this.btnNewOutputDoc.UseVisualStyleBackColor = true;
            this.btnNewOutputDoc.Click += new System.EventHandler(this.btnNewOutputDoc_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 302);
            this.Controls.Add(this.tlpMainFrame);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система за управление на продукти в сладкарница";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tlpMainFrame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputDocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dessertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDessertToolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tlpMainFrame;
        private System.Windows.Forms.Button btnNewInputDoc;
        private System.Windows.Forms.Button btnNewOutputDoc;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripComboBoxProduct;
    }
}

