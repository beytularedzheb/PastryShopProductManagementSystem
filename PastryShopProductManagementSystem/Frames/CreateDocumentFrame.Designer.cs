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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDocumentFrame));
            this.dessertDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.createDocButton = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dessertDataGridView)).BeginInit();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dessertDataGridView
            // 
            this.dessertDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dessertDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dessertDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dessertDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Quantity,
            this.Delete});
            this.dessertDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dessertDataGridView.Location = new System.Drawing.Point(0, 0);
            this.dessertDataGridView.Name = "dessertDataGridView";
            this.dessertDataGridView.Size = new System.Drawing.Size(632, 452);
            this.dessertDataGridView.TabIndex = 10;
            this.dessertDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dessertDataGridView_CellContentClick);
            this.dessertDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dessertDataGridView_EditingControlShowing);
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
            // btnPanel
            // 
            this.btnPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnPanel.Controls.Add(this.createDocButton);
            this.btnPanel.Controls.Add(this.btnCancel);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPanel.Location = new System.Drawing.Point(0, 382);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(632, 70);
            this.btnPanel.TabIndex = 12;
            // 
            // createDocButton
            // 
            this.createDocButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createDocButton.Location = new System.Drawing.Point(11, 12);
            this.createDocButton.Name = "createDocButton";
            this.createDocButton.Size = new System.Drawing.Size(140, 46);
            this.createDocButton.TabIndex = 1;
            this.createDocButton.Text = "Създай документ";
            this.createDocButton.UseVisualStyleBackColor = true;
            this.createDocButton.Click += new System.EventHandler(this.createDocButton_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(157, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 46);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отказ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.HeaderText = "Продукт";
            this.Product.MinimumWidth = 120;
            this.Product.Name = "Product";
            this.Product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Quantity.HeaderText = "Количество";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 101;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 60;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Text = "Изтрий";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 60;
            // 
            // CreateDocumentFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 452);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.dessertDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateDocumentFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Нов документ за вложени материали";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateDocumentFrame_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dessertDataGridView)).EndInit();
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dessertDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Button createDocButton;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewComboBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}