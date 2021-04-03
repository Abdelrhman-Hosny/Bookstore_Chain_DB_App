namespace Bookstore_Application
{
    partial class Books
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
            this.SearchBooks = new System.Windows.Forms.Button();
            this.EditBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddBooks
            // 
            this.AddBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.AddBooks.FlatAppearance.BorderSize = 0;
            this.AddBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBooks.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.AddBooks.Location = new System.Drawing.Point(57, 71);
            this.AddBooks.Name = "AddBooks";
            this.AddBooks.Size = new System.Drawing.Size(186, 40);
            this.AddBooks.TabIndex = 0;
            this.AddBooks.Text = "Add Books";
            this.AddBooks.UseVisualStyleBackColor = false;
            this.AddBooks.Click += new System.EventHandler(this.AddBooks_Click);
            // 
            // SearchBooks
            // 
            this.SearchBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.SearchBooks.FlatAppearance.BorderSize = 0;
            this.SearchBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBooks.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.SearchBooks.Location = new System.Drawing.Point(57, 203);
            this.SearchBooks.Name = "SearchBooks";
            this.SearchBooks.Size = new System.Drawing.Size(186, 40);
            this.SearchBooks.TabIndex = 1;
            this.SearchBooks.Text = "Search Books";
            this.SearchBooks.UseVisualStyleBackColor = false;
            this.SearchBooks.Click += new System.EventHandler(this.SearchBooks_Click);
            // 
            // EditBooks
            // 
            this.EditBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.EditBooks.FlatAppearance.BorderSize = 0;
            this.EditBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBooks.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.EditBooks.Location = new System.Drawing.Point(57, 354);
            this.EditBooks.Name = "EditBooks";
            this.EditBooks.Size = new System.Drawing.Size(186, 40);
            this.EditBooks.TabIndex = 2;
            this.EditBooks.Text = "Edit Books";
            this.EditBooks.UseVisualStyleBackColor = false;
            this.EditBooks.Click += new System.EventHandler(this.EditBooks_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.EditBooks);
            this.Controls.Add(this.SearchBooks);
            this.Controls.Add(this.AddBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Books";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBooks;
        private System.Windows.Forms.Button SearchBooks;
        private System.Windows.Forms.Button EditBooks;
    }
}