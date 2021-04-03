
namespace Bookstore_Application
{
    partial class CustomerShowSalesHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SalesHistoryGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SalesHistoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesHistoryGridView
            // 
            this.SalesHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesHistoryGridView.Location = new System.Drawing.Point(27, 78);
            this.SalesHistoryGridView.Name = "SalesHistoryGridView";
            this.SalesHistoryGridView.ReadOnly = true;
            this.SalesHistoryGridView.RowHeadersWidth = 51;
            this.SalesHistoryGridView.Size = new System.Drawing.Size(699, 358);
            this.SalesHistoryGridView.TabIndex = 0;
            this.SalesHistoryGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesHistoryGridView_CellClick);

            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label9.Location = new System.Drawing.Point(22, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Click on book to rate";
            // 
            // CustomerShowSalesHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SalesHistoryGridView);
            this.Name = "CustomerShowSalesHistory";
            this.Size = new System.Drawing.Size(765, 467);
            this.Load += new System.EventHandler(this.CustomerShowSalesHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesHistoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SalesHistoryGridView;
        private System.Windows.Forms.Label label9;
    }
}
