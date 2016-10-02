namespace PastryShopProductManagementSystem.Frames
{
    partial class InputDocumentCreationFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputDocumentCreationFrame));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.dgwInputDocument = new System.Windows.Forms.DataGridView();
            this.dataGridViewCalendarColumn1 = new PastryShopProductManagementSystem.CustomControls.DataGridViewCalendarColumn();
            this.dataGridViewNumericUpDownColumn1 = new PastryShopProductManagementSystem.CustomControls.DataGridViewNumericUpDownColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCalendarColumn2 = new PastryShopProductManagementSystem.CustomControls.DataGridViewCalendarColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivingDate = new PastryShopProductManagementSystem.CustomControls.DataGridViewCalendarColumn();
            this.Provider = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ReceivedQuantity = new PastryShopProductManagementSystem.CustomControls.DataGridViewNumericUpDownColumn();
            this.BatchNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new PastryShopProductManagementSystem.CustomControls.DataGridViewCalendarColumn();
            this.StorageCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInputDocument)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(11, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 46);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Запиши";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // btnPanel
            // 
            this.btnPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnPanel.Controls.Add(this.btnSave);
            this.btnPanel.Controls.Add(this.btnCancel);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPanel.Location = new System.Drawing.Point(0, 451);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(984, 70);
            this.btnPanel.TabIndex = 3;
            // 
            // dgwInputDocument
            // 
            this.dgwInputDocument.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwInputDocument.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwInputDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInputDocument.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReceivingDate,
            this.Provider,
            this.Product,
            this.ReceivedQuantity,
            this.BatchNumber,
            this.ExpiryDate,
            this.StorageCondition,
            this.Vehicle,
            this.Document,
            this.Delete});
            this.dgwInputDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwInputDocument.GridColor = System.Drawing.SystemColors.Control;
            this.dgwInputDocument.Location = new System.Drawing.Point(0, 0);
            this.dgwInputDocument.Name = "dgwInputDocument";
            this.dgwInputDocument.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgwInputDocument.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgwInputDocument.RowHeadersWidth = 25;
            this.dgwInputDocument.Size = new System.Drawing.Size(984, 521);
            this.dgwInputDocument.TabIndex = 0;
            this.dgwInputDocument.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwInputDocument_CellContentClick);
            // 
            // dataGridViewCalendarColumn1
            // 
            this.dataGridViewCalendarColumn1.FillWeight = 66.01261F;
            this.dataGridViewCalendarColumn1.HeaderText = "Дата на приемане";
            this.dataGridViewCalendarColumn1.Name = "dataGridViewCalendarColumn1";
            this.dataGridViewCalendarColumn1.Width = 116;
            // 
            // dataGridViewNumericUpDownColumn1
            // 
            this.dataGridViewNumericUpDownColumn1.FillWeight = 66.01261F;
            this.dataGridViewNumericUpDownColumn1.HeaderText = "Количество";
            this.dataGridViewNumericUpDownColumn1.Name = "dataGridViewNumericUpDownColumn1";
            this.dataGridViewNumericUpDownColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNumericUpDownColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewNumericUpDownColumn1.Width = 116;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 66.01261F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Партида";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 116;
            // 
            // dataGridViewCalendarColumn2
            // 
            this.dataGridViewCalendarColumn2.FillWeight = 66.01261F;
            this.dataGridViewCalendarColumn2.HeaderText = "Срок на годност";
            this.dataGridViewCalendarColumn2.Name = "dataGridViewCalendarColumn2";
            this.dataGridViewCalendarColumn2.Width = 117;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 66.01261F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Условия на съхранение";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 116;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 66.01261F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Транспортно средство";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 116;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 66.01261F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Придружаващ документ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 116;
            // 
            // ReceivingDate
            // 
            this.ReceivingDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReceivingDate.FillWeight = 66.01261F;
            this.ReceivingDate.HeaderText = "*Дата на приемане";
            this.ReceivingDate.Name = "ReceivingDate";
            this.ReceivingDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Provider
            // 
            this.Provider.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Provider.HeaderText = "*Доставчик";
            this.Provider.MinimumWidth = 125;
            this.Provider.Name = "Provider";
            this.Provider.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.HeaderText = "*Продукт";
            this.Product.MinimumWidth = 160;
            this.Product.Name = "Product";
            // 
            // ReceivedQuantity
            // 
            this.ReceivedQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReceivedQuantity.FillWeight = 66.01261F;
            this.ReceivedQuantity.HeaderText = "*Количество";
            this.ReceivedQuantity.Name = "ReceivedQuantity";
            this.ReceivedQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReceivedQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BatchNumber
            // 
            this.BatchNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchNumber.FillWeight = 66.01261F;
            this.BatchNumber.HeaderText = "*Партида";
            this.BatchNumber.Name = "BatchNumber";
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExpiryDate.FillWeight = 66.01261F;
            this.ExpiryDate.HeaderText = "*Срок на годност";
            this.ExpiryDate.Name = "ExpiryDate";
            // 
            // StorageCondition
            // 
            this.StorageCondition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StorageCondition.FillWeight = 66.01261F;
            this.StorageCondition.HeaderText = "Условия на съхранение";
            this.StorageCondition.Name = "StorageCondition";
            this.StorageCondition.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StorageCondition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Vehicle
            // 
            this.Vehicle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vehicle.FillWeight = 66.01261F;
            this.Vehicle.HeaderText = "Транспортно средство";
            this.Vehicle.Name = "Vehicle";
            // 
            // Document
            // 
            this.Document.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Document.FillWeight = 66.01261F;
            this.Document.HeaderText = "Придружаващ документ";
            this.Document.Name = "Document";
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 60;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Text = "Изтрий";
            this.Delete.ToolTipText = "Изтрий";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 60;
            // 
            // InputDocumentCreationFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 521);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.dgwInputDocument);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 560);
            this.Name = "InputDocumentCreationFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Създаване на нов документ за входящ контрол";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputDocumentCreationForm_FormClosing);
            this.btnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwInputDocument)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwInputDocument;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel btnPanel;
        private CustomControls.DataGridViewCalendarColumn dataGridViewCalendarColumn1;
        private CustomControls.DataGridViewNumericUpDownColumn dataGridViewNumericUpDownColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private CustomControls.DataGridViewCalendarColumn dataGridViewCalendarColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private CustomControls.DataGridViewCalendarColumn ReceivingDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn Provider;
        private System.Windows.Forms.DataGridViewComboBoxColumn Product;
        private CustomControls.DataGridViewNumericUpDownColumn ReceivedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNumber;
        private CustomControls.DataGridViewCalendarColumn ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StorageCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Document;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}