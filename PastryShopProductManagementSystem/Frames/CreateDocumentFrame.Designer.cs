namespace PastryShopProductManagementSystem.Frames
{
    partial class CreateDocumentFrame
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
            this.dessertDataGridView = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDocButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dessertDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dessertDataGridView
            // 
            this.dessertDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dessertDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dessertDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dessertDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Quantity,
            this.Delete});
            this.dessertDataGridView.Location = new System.Drawing.Point(12, 63);
            this.dessertDataGridView.Name = "dessertDataGridView";
            this.dessertDataGridView.Size = new System.Drawing.Size(515, 317);
            this.dessertDataGridView.TabIndex = 10;
            this.dessertDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dessertDataGridView_CellContentClick);
            this.dessertDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dessertDataGridView_EditingControlShowing);
            // 
            // Product
            // 
            this.Product.HeaderText = "Продукт";
            this.Product.Name = "Product";
            this.Product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Количество";
            this.Quantity.Name = "Quantity";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Изтрий";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Text = "Изтрий";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Продукт";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Изтрий";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // createDocButton
            // 
            this.createDocButton.Location = new System.Drawing.Point(12, 12);
            this.createDocButton.Name = "createDocButton";
            this.createDocButton.Size = new System.Drawing.Size(141, 45);
            this.createDocButton.TabIndex = 11;
            this.createDocButton.Text = "Създай документ";
            this.createDocButton.UseVisualStyleBackColor = true;
            this.createDocButton.Click += new System.EventHandler(this.createDocButton_Click);
            // 
            // CreateDocumentFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 392);
            this.Controls.Add(this.createDocButton);
            this.Controls.Add(this.dessertDataGridView);
            this.Name = "CreateDocumentFrame";
            this.Text = "Нов документ за вложени материали";
            ((System.ComponentModel.ISupportInitialize)(this.dessertDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dessertDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button createDocButton;
    }
}