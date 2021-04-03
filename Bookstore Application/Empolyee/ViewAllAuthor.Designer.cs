namespace Bookstore_Application
{
    partial class ViewAllAuthor
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
            this.bookstoreDataSet6 = new Bookstore_Application.BookstoreDataSet6();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorsTableAdapter = new Bookstore_Application.BookstoreDataSet6TableAdapters.AuthorsTableAdapter();
            this.authorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorIDDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.authorsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(709, 453);
            this.dataGridView1.TabIndex = 0;
            // 
            // bookstoreDataSet6
            // 
            this.bookstoreDataSet6.DataSetName = "BookstoreDataSet6";
            this.bookstoreDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.bookstoreDataSet6;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // authorIDDataGridViewTextBoxColumn
            // 
            this.authorIDDataGridViewTextBoxColumn.DataPropertyName = "Author_ID";
            this.authorIDDataGridViewTextBoxColumn.HeaderText = "Author_ID";
            this.authorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorIDDataGridViewTextBoxColumn.Name = "authorIDDataGridViewTextBoxColumn";
            this.authorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Fname";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ViewAllAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAllAuthor";
            this.Text = "ViewAllAuthor";
            this.Load += new System.EventHandler(this.ViewAllAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BookstoreDataSet6 bookstoreDataSet6;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private BookstoreDataSet6TableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    }
}