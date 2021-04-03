
namespace Bookstore_Application
{
    partial class BuyBooksUC
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
            this.BuyGridView = new System.Windows.Forms.DataGridView();
            this.BuyBooksButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BuyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BuyGridView
            // 
            this.BuyGridView.AllowUserToAddRows = false;
            this.BuyGridView.AllowUserToDeleteRows = false;
            this.BuyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuyGridView.Location = new System.Drawing.Point(16, 173);
            this.BuyGridView.Name = "BuyGridView";
            this.BuyGridView.RowHeadersWidth = 51;
            this.BuyGridView.Size = new System.Drawing.Size(698, 239);
            this.BuyGridView.TabIndex = 0;
            this.BuyGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoubleClickRow);
            // 
            // BuyBooksButton
            // 
            this.BuyBooksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BuyBooksButton.FlatAppearance.BorderSize = 0;
            this.BuyBooksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyBooksButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.BuyBooksButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BuyBooksButton.Location = new System.Drawing.Point(582, 120);
            this.BuyBooksButton.Name = "BuyBooksButton";
            this.BuyBooksButton.Size = new System.Drawing.Size(132, 37);
            this.BuyBooksButton.TabIndex = 1;
            this.BuyBooksButton.Text = "Buy";
            this.BuyBooksButton.UseVisualStyleBackColor = false;
            this.BuyBooksButton.Click += new System.EventHandler(this.BuyBooksButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(22, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Books In Cart: Double Click to Remove the Book from Cart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(22, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = " Click in Search to add to Cart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label3.Location = new System.Drawing.Point(493, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Price : ";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.PriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.PriceLabel.Location = new System.Drawing.Point(604, 431);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(18, 20);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "0";
            // 
            // BuyBooksUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuyBooksButton);
            this.Controls.Add(this.BuyGridView);
            this.Name = "BuyBooksUC";
            this.Size = new System.Drawing.Size(733, 477);
            this.Load += new System.EventHandler(this.BuyBooksUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BuyGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BuyGridView;
        private System.Windows.Forms.Button BuyBooksButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PriceLabel;
    }
}
