namespace Bookstore_Application
{
    partial class SearchBooks
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BookName_TextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.PublisherTextBox = new System.Windows.Forms.TextBox();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.Sort_Combobox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddBooks = new System.Windows.Forms.Button();
            this.SortOrder_Combobox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(220, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filter By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sort By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label4.Location = new System.Drawing.Point(327, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label5.Location = new System.Drawing.Point(508, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Language";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label6.Location = new System.Drawing.Point(327, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Genre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label7.Location = new System.Drawing.Point(511, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Publisher";
            // 
            // BookName_TextBox
            // 
            this.BookName_TextBox.Location = new System.Drawing.Point(114, 46);
            this.BookName_TextBox.Name = "BookName_TextBox";
            this.BookName_TextBox.Size = new System.Drawing.Size(100, 22);
            this.BookName_TextBox.TabIndex = 7;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(391, 46);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(100, 22);
            this.AuthorTextBox.TabIndex = 8;
            // 
            // PublisherTextBox
            // 
            this.PublisherTextBox.Location = new System.Drawing.Point(596, 128);
            this.PublisherTextBox.Name = "PublisherTextBox";
            this.PublisherTextBox.Size = new System.Drawing.Size(121, 22);
            this.PublisherTextBox.TabIndex = 9;
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Location = new System.Drawing.Point(596, 46);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(121, 24);
            this.LanguageComboBox.TabIndex = 10;
            this.LanguageComboBox.Click += new System.EventHandler(this.LanguageComboBox_Click);
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(391, 126);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(100, 24);
            this.GenreComboBox.TabIndex = 11;
            this.GenreComboBox.Click += new System.EventHandler(this.GenreComboBox_Click);
            // 
            // Sort_Combobox
            // 
            this.Sort_Combobox.FormattingEnabled = true;
            this.Sort_Combobox.Items.AddRange(new object[] {
            "None",
            "Price",
            "Rating",
            "Name"});
            this.Sort_Combobox.Location = new System.Drawing.Point(114, 107);
            this.Sort_Combobox.Name = "Sort_Combobox";
            this.Sort_Combobox.Size = new System.Drawing.Size(100, 24);
            this.Sort_Combobox.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(705, 249);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddToCart);
            // 
            // AddBooks
            // 
            this.AddBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.AddBooks.FlatAppearance.BorderSize = 0;
            this.AddBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBooks.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.AddBooks.Location = new System.Drawing.Point(596, 170);
            this.AddBooks.Name = "AddBooks";
            this.AddBooks.Size = new System.Drawing.Size(121, 40);
            this.AddBooks.TabIndex = 14;
            this.AddBooks.Text = "Search";
            this.AddBooks.UseVisualStyleBackColor = false;
            this.AddBooks.Click += new System.EventHandler(this.AddBooks_Click);
            // 
            // SortOrder_Combobox
            // 
            this.SortOrder_Combobox.FormattingEnabled = true;
            this.SortOrder_Combobox.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.SortOrder_Combobox.Location = new System.Drawing.Point(114, 158);
            this.SortOrder_Combobox.Name = "SortOrder_Combobox";
            this.SortOrder_Combobox.Size = new System.Drawing.Size(100, 24);
            this.SortOrder_Combobox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label8.Location = new System.Drawing.Point(12, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sort Order";
            // 
            // SearchBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.SortOrder_Combobox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddBooks);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Sort_Combobox);
            this.Controls.Add(this.GenreComboBox);
            this.Controls.Add(this.LanguageComboBox);
            this.Controls.Add(this.PublisherTextBox);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.BookName_TextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchBooks";
            this.Text = "SearchBooks";
            this.Load += new System.EventHandler(this.SearchBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BookName_TextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox PublisherTextBox;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.ComboBox Sort_Combobox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddBooks;
        private System.Windows.Forms.ComboBox SortOrder_Combobox;
        private System.Windows.Forms.Label label8;
    }
}