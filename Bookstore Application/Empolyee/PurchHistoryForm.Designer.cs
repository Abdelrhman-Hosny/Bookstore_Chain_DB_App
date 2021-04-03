namespace Bookstore_Application
{
    partial class PurchHistoryForm
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
            this.bookstoreDataSet3 = new Bookstore_Application.BookstoreDataSet3();
            this.salesHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sales_HistoryTableAdapter = new Bookstore_Application.BookstoreDataSet3TableAdapters.Sales_HistoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(709, 453);
            this.dataGridView1.TabIndex = 1;
            // 
            // bookstoreDataSet3
            // 
            this.bookstoreDataSet3.DataSetName = "BookstoreDataSet3";
            this.bookstoreDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesHistoryBindingSource
            // 
            this.salesHistoryBindingSource.DataMember = "Sales_History";
            this.salesHistoryBindingSource.DataSource = this.bookstoreDataSet3;
            // 
            // sales_HistoryTableAdapter
            // 
            this.sales_HistoryTableAdapter.ClearBeforeFill = true;
            // 
            // PurchHistoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchHistoryForm";
            this.Text = "PurchHistoryForm";
            this.Load += new System.EventHandler(this.PurchHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private BookstoreDataSet3 bookstoreDataSet3;
        private System.Windows.Forms.BindingSource salesHistoryBindingSource;
        private BookstoreDataSet3TableAdapters.Sales_HistoryTableAdapter sales_HistoryTableAdapter;
    }
}