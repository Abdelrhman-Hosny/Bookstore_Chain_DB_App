namespace Bookstore_Application
{
    partial class ViewAllBranches
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookstoreDataSet4 = new Bookstore_Application.BookstoreDataSet4();
            this.branchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchesTableAdapter = new Bookstore_Application.BookstoreDataSet4TableAdapters.BranchesTableAdapter();
            this.bookstoreDataSet5 = new Bookstore_Application.BookstoreDataSet5();
            this.branchesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.branchesTableAdapter1 = new Bookstore_Application.BookstoreDataSet5TableAdapters.BranchesTableAdapter();
            this.BranchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BranchName,
            this.branchIDDataGridViewTextBoxColumn,
            this.managerIDDataGridViewTextBoxColumn,
            this.branchLocationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.branchesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(709, 453);
            this.dataGridView1.TabIndex = 0;
            // 
            // bookstoreDataSet4
            // 
            this.bookstoreDataSet4.DataSetName = "BookstoreDataSet4";
            this.bookstoreDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branchesBindingSource
            // 
            this.branchesBindingSource.DataMember = "Branches";
            this.branchesBindingSource.DataSource = this.bookstoreDataSet4;
            // 
            // branchesTableAdapter
            // 
            this.branchesTableAdapter.ClearBeforeFill = true;
            // 
            // bookstoreDataSet5
            // 
            this.bookstoreDataSet5.DataSetName = "BookstoreDataSet5";
            this.bookstoreDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branchesBindingSource1
            // 
            this.branchesBindingSource1.DataMember = "Branches";
            this.branchesBindingSource1.DataSource = this.bookstoreDataSet5;
            // 
            // branchesTableAdapter1
            // 
            this.branchesTableAdapter1.ClearBeforeFill = true;
            // 
            // BranchName
            // 
            this.BranchName.DataPropertyName = "BranchName";
            this.BranchName.HeaderText = "BranchName";
            this.BranchName.MinimumWidth = 6;
            this.BranchName.Name = "BranchName";
            this.BranchName.Width = 125;
            // 
            // branchIDDataGridViewTextBoxColumn
            // 
            this.branchIDDataGridViewTextBoxColumn.DataPropertyName = "Branch_ID";
            this.branchIDDataGridViewTextBoxColumn.HeaderText = "Branch_ID";
            this.branchIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.branchIDDataGridViewTextBoxColumn.Name = "branchIDDataGridViewTextBoxColumn";
            this.branchIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // managerIDDataGridViewTextBoxColumn
            // 
            this.managerIDDataGridViewTextBoxColumn.DataPropertyName = "Manager_ID";
            this.managerIDDataGridViewTextBoxColumn.HeaderText = "Manager_ID";
            this.managerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.managerIDDataGridViewTextBoxColumn.Name = "managerIDDataGridViewTextBoxColumn";
            this.managerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // branchLocationDataGridViewTextBoxColumn
            // 
            this.branchLocationDataGridViewTextBoxColumn.DataPropertyName = "Branch_Location";
            this.branchLocationDataGridViewTextBoxColumn.HeaderText = "Branch_Location";
            this.branchLocationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.branchLocationDataGridViewTextBoxColumn.Name = "branchLocationDataGridViewTextBoxColumn";
            this.branchLocationDataGridViewTextBoxColumn.Width = 125;
            // 
            // ViewAllBranches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAllBranches";
            this.Text = "ViewAllBranches";
            this.Load += new System.EventHandler(this.ViewAllBranches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BookstoreDataSet4 bookstoreDataSet4;
        private System.Windows.Forms.BindingSource branchesBindingSource;
        private BookstoreDataSet4TableAdapters.BranchesTableAdapter branchesTableAdapter;
        private BookstoreDataSet5 bookstoreDataSet5;
        private System.Windows.Forms.BindingSource branchesBindingSource1;
        private BookstoreDataSet5TableAdapters.BranchesTableAdapter branchesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchLocationDataGridViewTextBoxColumn;
    }
}