namespace Bookstore_Application
{
    partial class AddBranch
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddBooks = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(158, 121);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(265, 22);
            this.textBox3.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label6.Location = new System.Drawing.Point(51, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Location";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 22);
            this.textBox2.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label7.Location = new System.Drawing.Point(28, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Manager ID";
            // 
            // AddBooks
            // 
            this.AddBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.AddBooks.FlatAppearance.BorderSize = 0;
            this.AddBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBooks.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.AddBooks.Location = new System.Drawing.Point(530, 404);
            this.AddBooks.Name = "AddBooks";
            this.AddBooks.Size = new System.Drawing.Size(186, 40);
            this.AddBooks.TabIndex = 43;
            this.AddBooks.Text = "Add Branch";
            this.AddBooks.UseVisualStyleBackColor = false;
            this.AddBooks.Click += new System.EventHandler(this.AddBooks_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 22);
            this.textBox1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Branch Name";
            // 
            // AddBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddBooks);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBranch";
            this.Text = "AddBanch";
            this.Load += new System.EventHandler(this.AddBranch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddBooks;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}