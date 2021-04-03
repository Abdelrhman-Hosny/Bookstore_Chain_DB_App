
namespace Bookstore_Application
{
    partial class RatingForm
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
            this.RatingCombobox = new System.Windows.Forms.ComboBox();
            this.RatingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(26, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rating : ";
            // 
            // RatingCombobox
            // 
            this.RatingCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RatingCombobox.FormattingEnabled = true;
            this.RatingCombobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.RatingCombobox.Location = new System.Drawing.Point(122, 65);
            this.RatingCombobox.Name = "RatingCombobox";
            this.RatingCombobox.Size = new System.Drawing.Size(121, 24);
            this.RatingCombobox.TabIndex = 1;
            // 
            // RatingButton
            // 
            this.RatingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.RatingButton.FlatAppearance.BorderSize = 0;
            this.RatingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RatingButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.RatingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.RatingButton.Location = new System.Drawing.Point(122, 133);
            this.RatingButton.Name = "RatingButton";
            this.RatingButton.Size = new System.Drawing.Size(121, 37);
            this.RatingButton.TabIndex = 2;
            this.RatingButton.Text = "Rate";
            this.RatingButton.UseVisualStyleBackColor = false;
            this.RatingButton.Click += new System.EventHandler(this.RatingButton_Click);
            // 
            // RatingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(332, 202);
            this.Controls.Add(this.RatingButton);
            this.Controls.Add(this.RatingCombobox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RatingForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RatingForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RatingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RatingCombobox;
        private System.Windows.Forms.Button RatingButton;
    }
}