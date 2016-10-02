namespace PastryShopProductManagementSystem.Frames
{
    partial class ShowOutputDocumentsFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowOutputDocumentsFrame));
            this.outputDocGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.show = new System.Windows.Forms.DataGridViewButtonColumn();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.showBtn = new System.Windows.Forms.Button();
            this.tlpOutputDocument = new System.Windows.Forms.TableLayoutPanel();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.outputDocGridView)).BeginInit();
            this.tlpOutputDocument.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputDocGridView
            // 
            this.outputDocGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDocGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputDocGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.outputDocGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputDocGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.issueDate,
            this.show});
            this.outputDocGridView.Location = new System.Drawing.Point(0, 95);
            this.outputDocGridView.Margin = new System.Windows.Forms.Padding(0);
            this.outputDocGridView.Name = "outputDocGridView";
            this.outputDocGridView.ReadOnly = true;
            this.outputDocGridView.Size = new System.Drawing.Size(449, 264);
            this.outputDocGridView.TabIndex = 0;
            this.outputDocGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.outputDocGridView_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "Номер на документ";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // issueDate
            // 
            this.issueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.issueDate.HeaderText = "Дата на издаване";
            this.issueDate.Name = "issueDate";
            this.issueDate.ReadOnly = true;
            // 
            // show
            // 
            this.show.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.show.HeaderText = "Покажи";
            this.show.Name = "show";
            this.show.ReadOnly = true;
            this.show.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.show.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.show.Text = "Покажи";
            this.show.UseColumnTextForButtonValue = true;
            this.show.Width = 77;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(83, 12);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(207, 21);
            this.fromDateTimePicker.TabIndex = 1;
            this.fromDateTimePicker.Value = new System.DateTime(2016, 9, 29, 10, 35, 50, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "От дата  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "До дата  :";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(83, 58);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(207, 21);
            this.toDateTimePicker.TabIndex = 4;
            this.toDateTimePicker.Value = new System.DateTime(2016, 9, 29, 13, 48, 45, 0);
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(305, 35);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(132, 45);
            this.showBtn.TabIndex = 5;
            this.showBtn.Text = "Покажи";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // tlpOutputDocument
            // 
            this.tlpOutputDocument.ColumnCount = 1;
            this.tlpOutputDocument.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOutputDocument.Controls.Add(this.outputDocGridView, 0, 1);
            this.tlpOutputDocument.Controls.Add(this.pnlControls, 0, 0);
            this.tlpOutputDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOutputDocument.Location = new System.Drawing.Point(0, 0);
            this.tlpOutputDocument.Name = "tlpOutputDocument";
            this.tlpOutputDocument.RowCount = 2;
            this.tlpOutputDocument.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tlpOutputDocument.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOutputDocument.Size = new System.Drawing.Size(449, 359);
            this.tlpOutputDocument.TabIndex = 6;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.label1);
            this.pnlControls.Controls.Add(this.showBtn);
            this.pnlControls.Controls.Add(this.fromDateTimePicker);
            this.pnlControls.Controls.Add(this.toDateTimePicker);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(449, 95);
            this.pnlControls.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер на документ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата на издаване";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ShowOutputDocumentsFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 359);
            this.Controls.Add(this.tlpOutputDocument);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowOutputDocumentsFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изходящи бележки";
            ((System.ComponentModel.ISupportInitialize)(this.outputDocGridView)).EndInit();
            this.tlpOutputDocument.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView outputDocGridView;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.TableLayoutPanel tlpOutputDocument;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDate;
        private System.Windows.Forms.DataGridViewButtonColumn show;
    }
}