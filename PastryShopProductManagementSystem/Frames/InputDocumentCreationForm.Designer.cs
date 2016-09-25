namespace PastryShopProductManagementSystem.Frames
{
    partial class InputDocumentCreationForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgwInputDocument = new System.Windows.Forms.DataGridView();
            this.ReceivingDate = new PastryShopProductManagementSystem.CustomControls.DataGridViewCalendarColumn();
            this.Provider = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ReceivedQuantity = new PastryShopProductManagementSystem.CustomControls.DataGridViewNumericUpDownColumn();
            this.BatchNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new PastryShopProductManagementSystem.CustomControls.DataGridViewCalendarColumn();
            this.StorageCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInputDocument)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(343, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Запиши";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(503, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отказ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 453);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 70);
            this.panel1.TabIndex = 3;
            // 
            // dgwInputDocument
            // 
            this.dgwInputDocument.AllowDrop = true;
            this.dgwInputDocument.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.Document});
            this.dgwInputDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwInputDocument.GridColor = System.Drawing.SystemColors.Control;
            this.dgwInputDocument.Location = new System.Drawing.Point(0, 0);
            this.dgwInputDocument.Name = "dgwInputDocument";
            this.dgwInputDocument.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgwInputDocument.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgwInputDocument.RowHeadersWidth = 25;
            this.dgwInputDocument.Size = new System.Drawing.Size(984, 523);
            this.dgwInputDocument.TabIndex = 0;
            // 
            // ReceivingDate
            // 
            this.ReceivingDate.HeaderText = "Дата на приемане";
            this.ReceivingDate.Name = "ReceivingDate";
            // 
            // Provider
            // 
            this.Provider.HeaderText = "Доставчик";
            this.Provider.Name = "Provider";
            // 
            // Product
            // 
            this.Product.HeaderText = "Продукт";
            this.Product.Name = "Product";
            // 
            // ReceivedQuantity
            // 
            this.ReceivedQuantity.HeaderText = "Количество";
            this.ReceivedQuantity.Name = "ReceivedQuantity";
            this.ReceivedQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReceivedQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BatchNumber
            // 
            this.BatchNumber.HeaderText = "Партида";
            this.BatchNumber.Name = "BatchNumber";
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.HeaderText = "Срок на годност";
            this.ExpiryDate.Name = "ExpiryDate";
            // 
            // StorageCondition
            // 
            this.StorageCondition.HeaderText = "Условия на съхранение";
            this.StorageCondition.Name = "StorageCondition";
            this.StorageCondition.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StorageCondition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Vehicle
            // 
            this.Vehicle.HeaderText = "Транспортно средство";
            this.Vehicle.Name = "Vehicle";
            // 
            // Document
            // 
            this.Document.HeaderText = "Придружаващ документ";
            this.Document.Name = "Document";
            // 
            // InputDocumentCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 523);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgwInputDocument);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "InputDocumentCreationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Създаване на нов документ за входящ контрол";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwInputDocument)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwInputDocument;
        private CustomControls.DataGridViewCalendarColumn ReceivingDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn Provider;
        private System.Windows.Forms.DataGridViewComboBoxColumn Product;
        private CustomControls.DataGridViewNumericUpDownColumn ReceivedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNumber;
        private CustomControls.DataGridViewCalendarColumn ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StorageCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Document;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}