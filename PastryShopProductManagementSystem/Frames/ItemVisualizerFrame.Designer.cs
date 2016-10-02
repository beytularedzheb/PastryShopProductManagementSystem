namespace PastryShopProductManagementSystem.Frames
{
    partial class ItemVisualizerFrame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemVisualizerFrame));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDesserts = new System.Windows.Forms.TabPage();
            this.dgwDesserts = new System.Windows.Forms.DataGridView();
            this.DessertName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DessertRecipeLines = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.tlpProduct = new System.Windows.Forms.TableLayoutPanel();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StorageCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxProductOptions = new System.Windows.Forms.GroupBox();
            this.rbProductsWithExpiredDate = new System.Windows.Forms.RadioButton();
            this.rbNotAvailableProducts = new System.Windows.Forms.RadioButton();
            this.rbAvailableProducts = new System.Windows.Forms.RadioButton();
            this.tabPageProviders = new System.Windows.Forms.TabPage();
            this.dgwProviders = new System.Windows.Forms.DataGridView();
            this.ProviderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dessertBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.tabPageDesserts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDesserts)).BeginInit();
            this.tabPageProducts.SuspendLayout();
            this.tlpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.groupBoxProductOptions.SuspendLayout();
            this.tabPageProviders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProviders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageDesserts);
            this.tabControl.Controls.Add(this.tabPageProducts);
            this.tabControl.Controls.Add(this.tabPageProviders);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(65, 45);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(15, 3);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(803, 534);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageDesserts
            // 
            this.tabPageDesserts.Controls.Add(this.dgwDesserts);
            this.tabPageDesserts.Location = new System.Drawing.Point(4, 49);
            this.tabPageDesserts.Name = "tabPageDesserts";
            this.tabPageDesserts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDesserts.Size = new System.Drawing.Size(795, 481);
            this.tabPageDesserts.TabIndex = 2;
            this.tabPageDesserts.Text = "Изделия";
            this.tabPageDesserts.UseVisualStyleBackColor = true;
            // 
            // dgwDesserts
            // 
            this.dgwDesserts.AllowUserToAddRows = false;
            this.dgwDesserts.AllowUserToDeleteRows = false;
            this.dgwDesserts.AllowUserToOrderColumns = true;
            this.dgwDesserts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDesserts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwDesserts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDesserts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DessertName,
            this.DessertRecipeLines});
            this.dgwDesserts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwDesserts.Location = new System.Drawing.Point(3, 3);
            this.dgwDesserts.Margin = new System.Windows.Forms.Padding(0);
            this.dgwDesserts.Name = "dgwDesserts";
            this.dgwDesserts.Size = new System.Drawing.Size(789, 475);
            this.dgwDesserts.TabIndex = 0;
            // 
            // DessertName
            // 
            this.DessertName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DessertName.HeaderText = "Име";
            this.DessertName.MinimumWidth = 150;
            this.DessertName.Name = "DessertName";
            this.DessertName.ReadOnly = true;
            this.DessertName.Width = 150;
            // 
            // DessertRecipeLines
            // 
            this.DessertRecipeLines.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DessertRecipeLines.HeaderText = "Необходими продукти";
            this.DessertRecipeLines.MinimumWidth = 150;
            this.DessertRecipeLines.Name = "DessertRecipeLines";
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.tlpProduct);
            this.tabPageProducts.Location = new System.Drawing.Point(4, 49);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(795, 481);
            this.tabPageProducts.TabIndex = 0;
            this.tabPageProducts.Text = "Продукти";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // tlpProduct
            // 
            this.tlpProduct.ColumnCount = 1;
            this.tlpProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProduct.Controls.Add(this.dgwProducts, 0, 1);
            this.tlpProduct.Controls.Add(this.groupBoxProductOptions, 0, 0);
            this.tlpProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProduct.Location = new System.Drawing.Point(3, 3);
            this.tlpProduct.Margin = new System.Windows.Forms.Padding(0);
            this.tlpProduct.Name = "tlpProduct";
            this.tlpProduct.RowCount = 2;
            this.tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProduct.Size = new System.Drawing.Size(789, 475);
            this.tlpProduct.TabIndex = 0;
            // 
            // dgwProducts
            // 
            this.dgwProducts.AllowUserToAddRows = false;
            this.dgwProducts.AllowUserToDeleteRows = false;
            this.dgwProducts.AllowUserToOrderColumns = true;
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.BatchNumber,
            this.AvailableQuantity,
            this.ExpiryDate,
            this.StorageCondition});
            this.dgwProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwProducts.Location = new System.Drawing.Point(3, 73);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.ReadOnly = true;
            this.dgwProducts.Size = new System.Drawing.Size(783, 399);
            this.dgwProducts.TabIndex = 1;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProductName.HeaderText = "Име";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 57;
            // 
            // BatchNumber
            // 
            this.BatchNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BatchNumber.HeaderText = "Партиден номер";
            this.BatchNumber.Name = "BatchNumber";
            this.BatchNumber.ReadOnly = true;
            this.BatchNumber.Width = 119;
            // 
            // AvailableQuantity
            // 
            this.AvailableQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AvailableQuantity.HeaderText = "Налично количество";
            this.AvailableQuantity.Name = "AvailableQuantity";
            this.AvailableQuantity.ReadOnly = true;
            this.AvailableQuantity.Width = 139;
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ExpiryDate.HeaderText = "Срок на годност";
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.ReadOnly = true;
            this.ExpiryDate.Width = 115;
            // 
            // StorageCondition
            // 
            this.StorageCondition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StorageCondition.HeaderText = "Условия за съхранение";
            this.StorageCondition.Name = "StorageCondition";
            this.StorageCondition.ReadOnly = true;
            // 
            // groupBoxProductOptions
            // 
            this.groupBoxProductOptions.Controls.Add(this.rbProductsWithExpiredDate);
            this.groupBoxProductOptions.Controls.Add(this.rbNotAvailableProducts);
            this.groupBoxProductOptions.Controls.Add(this.rbAvailableProducts);
            this.groupBoxProductOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxProductOptions.Location = new System.Drawing.Point(3, 0);
            this.groupBoxProductOptions.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBoxProductOptions.Name = "groupBoxProductOptions";
            this.groupBoxProductOptions.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxProductOptions.Size = new System.Drawing.Size(783, 70);
            this.groupBoxProductOptions.TabIndex = 2;
            this.groupBoxProductOptions.TabStop = false;
            // 
            // rbProductsWithExpiredDate
            // 
            this.rbProductsWithExpiredDate.AutoSize = true;
            this.rbProductsWithExpiredDate.Location = new System.Drawing.Point(226, 28);
            this.rbProductsWithExpiredDate.Name = "rbProductsWithExpiredDate";
            this.rbProductsWithExpiredDate.Size = new System.Drawing.Size(177, 19);
            this.rbProductsWithExpiredDate.TabIndex = 2;
            this.rbProductsWithExpiredDate.Text = "С изтекъл срок на госност";
            this.rbProductsWithExpiredDate.UseVisualStyleBackColor = true;
            this.rbProductsWithExpiredDate.CheckedChanged += new System.EventHandler(this.rbProductsWithExpiredDate_CheckedChanged);
            // 
            // rbNotAvailableProducts
            // 
            this.rbNotAvailableProducts.AutoSize = true;
            this.rbNotAvailableProducts.Location = new System.Drawing.Point(132, 28);
            this.rbNotAvailableProducts.Name = "rbNotAvailableProducts";
            this.rbNotAvailableProducts.Size = new System.Drawing.Size(88, 19);
            this.rbNotAvailableProducts.TabIndex = 1;
            this.rbNotAvailableProducts.Text = "Изчерпани";
            this.rbNotAvailableProducts.UseVisualStyleBackColor = true;
            this.rbNotAvailableProducts.CheckedChanged += new System.EventHandler(this.rbNotAvailableProducts_CheckedChanged);
            // 
            // rbAvailableProducts
            // 
            this.rbAvailableProducts.AutoSize = true;
            this.rbAvailableProducts.Checked = true;
            this.rbAvailableProducts.Location = new System.Drawing.Point(5, 28);
            this.rbAvailableProducts.Name = "rbAvailableProducts";
            this.rbAvailableProducts.Size = new System.Drawing.Size(121, 19);
            this.rbAvailableProducts.TabIndex = 0;
            this.rbAvailableProducts.TabStop = true;
            this.rbAvailableProducts.Text = "Налични и годни";
            this.rbAvailableProducts.UseVisualStyleBackColor = true;
            this.rbAvailableProducts.CheckedChanged += new System.EventHandler(this.rbAvailableProducts_CheckedChanged);
            // 
            // tabPageProviders
            // 
            this.tabPageProviders.Controls.Add(this.dgwProviders);
            this.tabPageProviders.Location = new System.Drawing.Point(4, 49);
            this.tabPageProviders.Name = "tabPageProviders";
            this.tabPageProviders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProviders.Size = new System.Drawing.Size(795, 481);
            this.tabPageProviders.TabIndex = 1;
            this.tabPageProviders.Text = "Доставчици";
            this.tabPageProviders.UseVisualStyleBackColor = true;
            // 
            // dgwProviders
            // 
            this.dgwProviders.AllowUserToAddRows = false;
            this.dgwProviders.AllowUserToDeleteRows = false;
            this.dgwProviders.AllowUserToOrderColumns = true;
            this.dgwProviders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProviders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProviders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProviderName});
            this.dgwProviders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwProviders.Location = new System.Drawing.Point(3, 3);
            this.dgwProviders.Name = "dgwProviders";
            this.dgwProviders.ReadOnly = true;
            this.dgwProviders.Size = new System.Drawing.Size(789, 475);
            this.dgwProviders.TabIndex = 0;
            // 
            // ProviderName
            // 
            this.ProviderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProviderName.HeaderText = "Име";
            this.ProviderName.Name = "ProviderName";
            this.ProviderName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Име";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Име";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Партиден номер";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "Налично количество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "Срок на годност";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Условия за съхранение";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "Име";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(PastryShopProductManagementSystem.Models.Product);
            // 
            // dessertBindingSource
            // 
            this.dessertBindingSource.DataSource = typeof(PastryShopProductManagementSystem.Models.Dessert);
            // 
            // ItemVisualizerFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 534);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemVisualizerFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabControl.ResumeLayout(false);
            this.tabPageDesserts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDesserts)).EndInit();
            this.tabPageProducts.ResumeLayout(false);
            this.tlpProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.groupBoxProductOptions.ResumeLayout(false);
            this.groupBoxProductOptions.PerformLayout();
            this.tabPageProviders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProviders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageProducts;
        private System.Windows.Forms.TabPage tabPageProviders;
        private System.Windows.Forms.TabPage tabPageDesserts;
        private System.Windows.Forms.DataGridView dgwDesserts;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource dessertBindingSource;
        private System.Windows.Forms.DataGridView dgwProviders;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProviderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TableLayoutPanel tlpProduct;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StorageCondition;
        private System.Windows.Forms.GroupBox groupBoxProductOptions;
        private System.Windows.Forms.RadioButton rbProductsWithExpiredDate;
        private System.Windows.Forms.RadioButton rbNotAvailableProducts;
        private System.Windows.Forms.RadioButton rbAvailableProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn DessertName;
        private System.Windows.Forms.DataGridViewComboBoxColumn DessertRecipeLines;
    }
}