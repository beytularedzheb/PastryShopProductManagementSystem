namespace PastryShopProductManagementSystem.Frames
{
    partial class AddNewItemFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewItemFrame));
            this.tabCtrlItems = new System.Windows.Forms.TabControl();
            this.tabPageDessert = new System.Windows.Forms.TabPage();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDessertDetails = new System.Windows.Forms.Panel();
            this.tbDessertName = new System.Windows.Forms.TextBox();
            this.lblDessertName = new System.Windows.Forms.Label();
            this.tlpRecipeContent = new System.Windows.Forms.TableLayoutPanel();
            this.dgwRecipe = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity = new PastryShopProductManagementSystem.CustomControls.DataGridViewNumericUpDownColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblNeededProducts = new System.Windows.Forms.Label();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.tbProductUnit = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tabPageProvider = new System.Windows.Forms.TabPage();
            this.tbProviderName = new System.Windows.Forms.TextBox();
            this.lblProviderName = new System.Windows.Forms.Label();
            this.dataGridViewNumericUpDownColumn1 = new PastryShopProductManagementSystem.CustomControls.DataGridViewNumericUpDownColumn();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabCtrlItems.SuspendLayout();
            this.tabPageDessert.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.pnlDessertDetails.SuspendLayout();
            this.tlpRecipeContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRecipe)).BeginInit();
            this.tabPageProduct.SuspendLayout();
            this.tabPageProvider.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrlItems
            // 
            this.tabCtrlItems.Controls.Add(this.tabPageDessert);
            this.tabCtrlItems.Controls.Add(this.tabPageProduct);
            this.tabCtrlItems.Controls.Add(this.tabPageProvider);
            this.tabCtrlItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabCtrlItems.ItemSize = new System.Drawing.Size(65, 45);
            this.tabCtrlItems.Location = new System.Drawing.Point(0, 0);
            this.tabCtrlItems.Multiline = true;
            this.tabCtrlItems.Name = "tabCtrlItems";
            this.tabCtrlItems.Padding = new System.Drawing.Point(15, 3);
            this.tabCtrlItems.SelectedIndex = 0;
            this.tabCtrlItems.Size = new System.Drawing.Size(637, 493);
            this.tabCtrlItems.TabIndex = 0;
            // 
            // tabPageDessert
            // 
            this.tabPageDessert.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageDessert.Controls.Add(this.tlpContent);
            this.tabPageDessert.Location = new System.Drawing.Point(4, 49);
            this.tabPageDessert.Name = "tabPageDessert";
            this.tabPageDessert.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDessert.Size = new System.Drawing.Size(629, 440);
            this.tabPageDessert.TabIndex = 0;
            this.tabPageDessert.Text = "Изделие";
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 1;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContent.Controls.Add(this.pnlDessertDetails, 0, 0);
            this.tlpContent.Controls.Add(this.tlpRecipeContent, 0, 1);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(3, 3);
            this.tlpContent.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.RowCount = 2;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.75179F));
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.24821F));
            this.tlpContent.Size = new System.Drawing.Size(623, 434);
            this.tlpContent.TabIndex = 8;
            // 
            // pnlDessertDetails
            // 
            this.pnlDessertDetails.Controls.Add(this.tbDessertName);
            this.pnlDessertDetails.Controls.Add(this.lblDessertName);
            this.pnlDessertDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDessertDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlDessertDetails.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDessertDetails.Name = "pnlDessertDetails";
            this.pnlDessertDetails.Size = new System.Drawing.Size(623, 68);
            this.pnlDessertDetails.TabIndex = 1;
            // 
            // tbDessertName
            // 
            this.tbDessertName.Location = new System.Drawing.Point(8, 28);
            this.tbDessertName.Name = "tbDessertName";
            this.tbDessertName.Size = new System.Drawing.Size(294, 21);
            this.tbDessertName.TabIndex = 1;
            // 
            // lblDessertName
            // 
            this.lblDessertName.AutoSize = true;
            this.lblDessertName.Location = new System.Drawing.Point(5, 10);
            this.lblDessertName.Name = "lblDessertName";
            this.lblDessertName.Size = new System.Drawing.Size(40, 15);
            this.lblDessertName.TabIndex = 0;
            this.lblDessertName.Text = "*Име:";
            this.lblDessertName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpRecipeContent
            // 
            this.tlpRecipeContent.ColumnCount = 1;
            this.tlpRecipeContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRecipeContent.Controls.Add(this.dgwRecipe, 0, 1);
            this.tlpRecipeContent.Controls.Add(this.lblNeededProducts, 0, 0);
            this.tlpRecipeContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRecipeContent.Location = new System.Drawing.Point(0, 68);
            this.tlpRecipeContent.Margin = new System.Windows.Forms.Padding(0);
            this.tlpRecipeContent.Name = "tlpRecipeContent";
            this.tlpRecipeContent.RowCount = 2;
            this.tlpRecipeContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.187135F));
            this.tlpRecipeContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.81287F));
            this.tlpRecipeContent.Size = new System.Drawing.Size(623, 366);
            this.tlpRecipeContent.TabIndex = 2;
            // 
            // dgwRecipe
            // 
            this.dgwRecipe.AllowDrop = true;
            this.dgwRecipe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwRecipe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRecipe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Quantity,
            this.Delete});
            this.dgwRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwRecipe.GridColor = System.Drawing.SystemColors.Control;
            this.dgwRecipe.Location = new System.Drawing.Point(0, 29);
            this.dgwRecipe.Margin = new System.Windows.Forms.Padding(0);
            this.dgwRecipe.Name = "dgwRecipe";
            this.dgwRecipe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgwRecipe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgwRecipe.RowHeadersWidth = 25;
            this.dgwRecipe.Size = new System.Drawing.Size(623, 337);
            this.dgwRecipe.TabIndex = 5;
            this.dgwRecipe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwRecipe_CellContentClick);
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Product.FillWeight = 66.01261F;
            this.Product.HeaderText = "*Продукт";
            this.Product.MinimumWidth = 120;
            this.Product.Name = "Product";
            this.Product.Width = 120;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.FillWeight = 66.01261F;
            this.Quantity.HeaderText = "*Количество";
            this.Quantity.Name = "Quantity";
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // lblNeededProducts
            // 
            this.lblNeededProducts.AutoSize = true;
            this.lblNeededProducts.Location = new System.Drawing.Point(3, 0);
            this.lblNeededProducts.Name = "lblNeededProducts";
            this.lblNeededProducts.Size = new System.Drawing.Size(139, 15);
            this.lblNeededProducts.TabIndex = 6;
            this.lblNeededProducts.Text = "Необходими продукти:";
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Controls.Add(this.tbProductUnit);
            this.tabPageProduct.Controls.Add(this.lblUnit);
            this.tabPageProduct.Controls.Add(this.tbProductName);
            this.tabPageProduct.Controls.Add(this.lblProductName);
            this.tabPageProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageProduct.Location = new System.Drawing.Point(4, 49);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(629, 440);
            this.tabPageProduct.TabIndex = 1;
            this.tabPageProduct.Text = "Продукт";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // tbProductUnit
            // 
            this.tbProductUnit.Location = new System.Drawing.Point(11, 90);
            this.tbProductUnit.Name = "tbProductUnit";
            this.tbProductUnit.Size = new System.Drawing.Size(162, 21);
            this.tbProductUnit.TabIndex = 4;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(8, 72);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(106, 15);
            this.lblUnit.TabIndex = 3;
            this.lblUnit.Text = "*Мерна единица:";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(11, 31);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(294, 21);
            this.tbProductName.TabIndex = 2;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(8, 13);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(40, 15);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "*Име:";
            // 
            // tabPageProvider
            // 
            this.tabPageProvider.Controls.Add(this.tbProviderName);
            this.tabPageProvider.Controls.Add(this.lblProviderName);
            this.tabPageProvider.Location = new System.Drawing.Point(4, 49);
            this.tabPageProvider.Name = "tabPageProvider";
            this.tabPageProvider.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProvider.Size = new System.Drawing.Size(629, 440);
            this.tabPageProvider.TabIndex = 2;
            this.tabPageProvider.Text = "Доставчик";
            this.tabPageProvider.UseVisualStyleBackColor = true;
            // 
            // tbProviderName
            // 
            this.tbProviderName.Location = new System.Drawing.Point(11, 31);
            this.tbProviderName.Name = "tbProviderName";
            this.tbProviderName.Size = new System.Drawing.Size(294, 21);
            this.tbProviderName.TabIndex = 4;
            // 
            // lblProviderName
            // 
            this.lblProviderName.AutoSize = true;
            this.lblProviderName.Location = new System.Drawing.Point(8, 13);
            this.lblProviderName.Name = "lblProviderName";
            this.lblProviderName.Size = new System.Drawing.Size(40, 15);
            this.lblProviderName.TabIndex = 3;
            this.lblProviderName.Text = "*Име:";
            // 
            // dataGridViewNumericUpDownColumn1
            // 
            this.dataGridViewNumericUpDownColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewNumericUpDownColumn1.FillWeight = 66.01261F;
            this.dataGridViewNumericUpDownColumn1.HeaderText = "*Количество";
            this.dataGridViewNumericUpDownColumn1.Name = "dataGridViewNumericUpDownColumn1";
            this.dataGridViewNumericUpDownColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNumericUpDownColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnPanel
            // 
            this.btnPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnPanel.Controls.Add(this.btnSave);
            this.btnPanel.Controls.Add(this.btnCancel);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPanel.Location = new System.Drawing.Point(0, 413);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(637, 80);
            this.btnPanel.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(13, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 53);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Запиши";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(183, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 53);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отказ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddNewItemFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 493);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.tabCtrlItems);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewItemFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма за добавяне";
            this.tabCtrlItems.ResumeLayout(false);
            this.tabPageDessert.ResumeLayout(false);
            this.tlpContent.ResumeLayout(false);
            this.pnlDessertDetails.ResumeLayout(false);
            this.pnlDessertDetails.PerformLayout();
            this.tlpRecipeContent.ResumeLayout(false);
            this.tlpRecipeContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRecipe)).EndInit();
            this.tabPageProduct.ResumeLayout(false);
            this.tabPageProduct.PerformLayout();
            this.tabPageProvider.ResumeLayout(false);
            this.tabPageProvider.PerformLayout();
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlItems;
        private System.Windows.Forms.TabPage tabPageDessert;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.TabPage tabPageProvider;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.Panel pnlDessertDetails;
        private System.Windows.Forms.TextBox tbDessertName;
        private System.Windows.Forms.Label lblDessertName;
        private System.Windows.Forms.TableLayoutPanel tlpRecipeContent;
        private System.Windows.Forms.DataGridView dgwRecipe;
        private System.Windows.Forms.DataGridViewComboBoxColumn Product;
        private CustomControls.DataGridViewNumericUpDownColumn Quantity;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label lblNeededProducts;
        private CustomControls.DataGridViewNumericUpDownColumn dataGridViewNumericUpDownColumn1;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbProductUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox tbProviderName;
        private System.Windows.Forms.Label lblProviderName;
    }
}