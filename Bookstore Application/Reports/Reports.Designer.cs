namespace Bookstore_Application
{
    partial class Reports
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.BranchReview1 = new Bookstore_Application.BranchReview();
            this.BranchReview2 = new Bookstore_Application.BranchReview();
            this.BranchReview3 = new Bookstore_Application.BranchReview();
            this.BranchReview4 = new Bookstore_Application.BranchReview();
            this.BranchReview5 = new Bookstore_Application.BranchReview();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = "D:\\University\\College Files\\CCE Juinor\\Fall 2020\\Introduction to Database Managem" +
    "ent\\Project\\Final Final\\Bookstore_Chain_DB_App\\Bookstore Application\\BranchRevie" +
    "w.rpt";
            this.crystalReportViewer1.Size = new System.Drawing.Size(733, 478);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelWidth = 267;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 478);
            this.Controls.Add(this.crystalReportViewer1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private BranchReview BranchReview1;
        private BranchReview BranchReview2;
        private BranchReview BranchReview4;
        private BranchReview BranchReview3;
        private BranchReview BranchReview5;
    }
}