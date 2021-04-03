namespace Bookstore_Application
{
    partial class AddPurch
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
            this.AddBooks = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BuyGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BuyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBooks
            // 
            this.AddBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.AddBooks.FlatAppearance.BorderSize = 0;
            this.AddBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBooks.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.AddBooks.Location = new System.Drawing.Point(589, 93);
            this.AddBooks.Name = "AddBooks";
            this.AddBooks.Size = new System.Drawing.Size(132, 37);
            this.AddBooks.TabIndex = 26;
            this.AddBooks.Text = "Buy";
            this.AddBooks.UseVisualStyleBackColor = false;
            this.AddBooks.Click += new System.EventHandler(this.AddBooks_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 22);
            this.textBox1.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label6.Location = new System.Drawing.Point(23, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Click in Search to add to Cart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Customer ID";
            // 
            // BuyGridView
            // 
            this.BuyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuyGridView.Location = new System.Drawing.Point(12, 153);
            this.BuyGridView.Name = "BuyGridView";
            this.BuyGridView.RowHeadersWidth = 51;
            this.BuyGridView.RowTemplate.Height = 24;
            this.BuyGridView.Size = new System.Drawing.Size(709, 265);
            this.BuyGridView.TabIndex = 27;
            this.BuyGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoubleClickRow);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label4.Location = new System.Drawing.Point(172, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(525, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Total Price:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.PriceLabel.Location = new System.Drawing.Point(617, 435);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(18, 20);
            this.PriceLabel.TabIndex = 30;
            this.PriceLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label3.Location = new System.Drawing.Point(23, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(488, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Books In Cart: Double Click to Remove From Cart";
            // 
            // AddPurch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BuyGridView);
            this.Controls.Add(this.AddBooks);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPurch";
            this.Text = "AddPurch";
            this.Load += new System.EventHandler(this.AddPurch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BuyGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBooks;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView BuyGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label label3;
    }
}