
namespace Bookstore_Application
{
    partial class CustomerBookSearch_UserControl
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
            this.SortOrder_Combobox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddBooks = new System.Windows.Forms.Button();
            this.BookSearchGrid = new System.Windows.Forms.DataGridView();
            this.Sort_Combobox = new System.Windows.Forms.ComboBox();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.PublisherTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.BookName_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BookSearchGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SortOrder_Combobox
            // 
            this.SortOrder_Combobox.FormattingEnabled = true;
            this.SortOrder_Combobox.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.SortOrder_Combobox.Location = new System.Drawing.Point(114, 141);
            this.SortOrder_Combobox.Name = "SortOrder_Combobox";
            this.SortOrder_Combobox.Size = new System.Drawing.Size(100, 24);
            this.SortOrder_Combobox.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label8.Location = new System.Drawing.Point(12, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Sort Order";
            // 
            // AddBooks
            // 
            this.AddBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.AddBooks.FlatAppearance.BorderSize = 0;
            this.AddBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBooks.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.AddBooks.Location = new System.Drawing.Point(596, 153);
            this.AddBooks.Name = "AddBooks";
            this.AddBooks.Size = new System.Drawing.Size(121, 40);
            this.AddBooks.TabIndex = 31;
            this.AddBooks.Text = "Search";
            this.AddBooks.UseVisualStyleBackColor = false;
            this.AddBooks.Click += new System.EventHandler(this.AddBooks_Click);
            // 
            // BookSearchGrid
            // 
            this.BookSearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookSearchGrid.Location = new System.Drawing.Point(16, 199);
            this.BookSearchGrid.Name = "BookSearchGrid";
            this.BookSearchGrid.RowHeadersWidth = 51;
            this.BookSearchGrid.RowTemplate.Height = 24;
            this.BookSearchGrid.Size = new System.Drawing.Size(705, 249);
            this.BookSearchGrid.TabIndex = 30;
            this.BookSearchGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookSearchGrid_CellClick);
            // 
            // Sort_Combobox
            // 
            this.Sort_Combobox.FormattingEnabled = true;
            this.Sort_Combobox.Items.AddRange(new object[] {
            "None",
            "Price",
            "Rating",
            "Name"});
            this.Sort_Combobox.Location = new System.Drawing.Point(114, 90);
            this.Sort_Combobox.Name = "Sort_Combobox";
            this.Sort_Combobox.Size = new System.Drawing.Size(100, 24);
            this.Sort_Combobox.TabIndex = 29;
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(391, 109);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(100, 24);
            this.GenreComboBox.TabIndex = 28;
            this.GenreComboBox.Click += new System.EventHandler(this.GenreComboBox_Click_1);
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Location = new System.Drawing.Point(596, 29);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(121, 24);
            this.LanguageComboBox.TabIndex = 27;
            this.LanguageComboBox.Click += new System.EventHandler(this.LanguageComboBox_Click_1);
            // 
            // PublisherTextBox
            // 
            this.PublisherTextBox.Location = new System.Drawing.Point(596, 111);
            this.PublisherTextBox.Name = "PublisherTextBox";
            this.PublisherTextBox.Size = new System.Drawing.Size(121, 22);
            this.PublisherTextBox.TabIndex = 26;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(391, 29);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(100, 22);
            this.AuthorTextBox.TabIndex = 25;
            // 
            // BookName_TextBox
            // 
            this.BookName_TextBox.Location = new System.Drawing.Point(114, 29);
            this.BookName_TextBox.Name = "BookName_TextBox";
            this.BookName_TextBox.Size = new System.Drawing.Size(100, 22);
            this.BookName_TextBox.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label7.Location = new System.Drawing.Point(511, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Publisher";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label6.Location = new System.Drawing.Point(327, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label5.Location = new System.Drawing.Point(508, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Language";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label4.Location = new System.Drawing.Point(327, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sort By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(220, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Filter By";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Book Name";
            // 
            // CustomerBookSearch_UserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.SortOrder_Combobox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddBooks);
            this.Controls.Add(this.BookSearchGrid);
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
            this.Location = new System.Drawing.Point(186, 110);
            this.Name = "CustomerBookSearch_UserControl";
            this.Size = new System.Drawing.Size(733, 477);
            this.Load += new System.EventHandler(this.CustomerBookSearch_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookSearchGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SortOrder_Combobox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddBooks;
        private System.Windows.Forms.DataGridView BookSearchGrid;
        private System.Windows.Forms.ComboBox Sort_Combobox;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.TextBox PublisherTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox BookName_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
