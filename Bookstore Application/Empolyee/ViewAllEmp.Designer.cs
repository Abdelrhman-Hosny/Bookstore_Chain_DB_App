namespace Bookstore_Application
{
    partial class ViewAllEmp
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
            this.bookstoreDataSet = new Bookstore_Application.BookstoreDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new Bookstore_Application.BookstoreDataSetTableAdapters.EmployeesTableAdapter();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIDDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.midNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.empAddressDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.branchIDDataGridViewTextBoxColumn,
            this.managerIDDataGridViewTextBoxColumn,
            this.empEmailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(705, 453);
            this.dataGridView1.TabIndex = 28;
            // 
            // bookstoreDataSet
            // 
            this.bookstoreDataSet.DataSetName = "BookstoreDataSet";
            this.bookstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.bookstoreDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Fname";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // midNameDataGridViewTextBoxColumn
            // 
            this.midNameDataGridViewTextBoxColumn.DataPropertyName = "MidName";
            this.midNameDataGridViewTextBoxColumn.HeaderText = "MidName";
            this.midNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.midNameDataGridViewTextBoxColumn.Name = "midNameDataGridViewTextBoxColumn";
            this.midNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // empAddressDataGridViewTextBoxColumn
            // 
            this.empAddressDataGridViewTextBoxColumn.DataPropertyName = "Emp_Address";
            this.empAddressDataGridViewTextBoxColumn.HeaderText = "Emp_Address";
            this.empAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empAddressDataGridViewTextBoxColumn.Name = "empAddressDataGridViewTextBoxColumn";
            this.empAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.Width = 125;
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
            // empEmailDataGridViewTextBoxColumn
            // 
            this.empEmailDataGridViewTextBoxColumn.DataPropertyName = "Emp_Email";
            this.empEmailDataGridViewTextBoxColumn.HeaderText = "Emp_Email";
            this.empEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empEmailDataGridViewTextBoxColumn.Name = "empEmailDataGridViewTextBoxColumn";
            this.empEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // ViewAllEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAllEmp";
            this.Text = "SearchForEmp";
            this.Load += new System.EventHandler(this.ViewAllEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private BookstoreDataSet bookstoreDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private BookstoreDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empEmailDataGridViewTextBoxColumn;
    }
}