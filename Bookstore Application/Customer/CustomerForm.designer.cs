
namespace Bookstore_Application
{
    partial class CustomerForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TopRated = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.BuyButton = new System.Windows.Forms.Button();
            this.ShowHistory_Button = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MailLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.ShowPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.TopRated);
            this.panel1.Controls.Add(this.btnMainMenu);
            this.panel1.Controls.Add(this.LogOutButton);
            this.panel1.Controls.Add(this.SettingsButton);
            this.panel1.Controls.Add(this.BuyButton);
            this.panel1.Controls.Add(this.ShowHistory_Button);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // TopRated
            // 
            this.TopRated.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopRated.FlatAppearance.BorderSize = 0;
            this.TopRated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopRated.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopRated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.TopRated.Image = global::Bookstore_Application.Properties.Resources.increase_32px;
            this.TopRated.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TopRated.Location = new System.Drawing.Point(0, 287);
            this.TopRated.Name = "TopRated";
            this.TopRated.Size = new System.Drawing.Size(186, 60);
            this.TopRated.TabIndex = 9;
            this.TopRated.Text = "Check Top Rated Books";
            this.TopRated.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TopRated.UseVisualStyleBackColor = true;
            this.TopRated.Click += new System.EventHandler(this.TopRated_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMainMenu.Image = global::Bookstore_Application.Properties.Resources.Home_Icon;
            this.btnMainMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMainMenu.Location = new System.Drawing.Point(0, 461);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(186, 40);
            this.btnMainMenu.TabIndex = 8;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LogOutButton.Image = global::Bookstore_Application.Properties.Resources.LogOut_Icon;
            this.LogOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogOutButton.Location = new System.Drawing.Point(0, 535);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(186, 40);
            this.LogOutButton.TabIndex = 6;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.SettingsButton.Image = global::Bookstore_Application.Properties.Resources.Settings_Icon;
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SettingsButton.Location = new System.Drawing.Point(0, 495);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(186, 40);
            this.SettingsButton.TabIndex = 5;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // BuyButton
            // 
            this.BuyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BuyButton.FlatAppearance.BorderSize = 0;
            this.BuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BuyButton.Image = global::Bookstore_Application.Properties.Resources.Buy_Icon;
            this.BuyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuyButton.Location = new System.Drawing.Point(0, 247);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(186, 40);
            this.BuyButton.TabIndex = 3;
            this.BuyButton.Text = "Buy";
            this.BuyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // ShowHistory_Button
            // 
            this.ShowHistory_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShowHistory_Button.FlatAppearance.BorderSize = 0;
            this.ShowHistory_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowHistory_Button.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowHistory_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ShowHistory_Button.Image = global::Bookstore_Application.Properties.Resources.History_Icon;
            this.ShowHistory_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowHistory_Button.Location = new System.Drawing.Point(0, 207);
            this.ShowHistory_Button.Name = "ShowHistory_Button";
            this.ShowHistory_Button.Size = new System.Drawing.Size(186, 40);
            this.ShowHistory_Button.TabIndex = 2;
            this.ShowHistory_Button.Text = "Sales History";
            this.ShowHistory_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ShowHistory_Button.UseVisualStyleBackColor = true;
            this.ShowHistory_Button.Click += new System.EventHandler(this.ShowHistory_Button_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.SearchBtn.Image = global::Bookstore_Application.Properties.Resources.Search_Icon;
            this.SearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchBtn.Location = new System.Drawing.Point(0, 167);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(186, 40);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.MailLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 167);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(53, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(249)))));
            this.MailLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MailLabel.Location = new System.Drawing.Point(76, 115);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(28, 20);
            this.MailLabel.TabIndex = 1;
            this.MailLabel.Text = "ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bookstore_Application.Properties.Resources._114_1147557_education_icon_set_book_icon_png_circle_clipart;
            this.pictureBox1.Location = new System.Drawing.Point(40, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.NavigationPanel.Location = new System.Drawing.Point(0, 193);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(3, 100);
            this.NavigationPanel.TabIndex = 1;
            // 
            // ShowPanel
            // 
            this.ShowPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ShowPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ShowPanel.Location = new System.Drawing.Point(186, 100);
            this.ShowPanel.Name = "ShowPanel";
            this.ShowPanel.Size = new System.Drawing.Size(765, 477);
            this.ShowPanel.TabIndex = 2;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.HeaderLabel.Location = new System.Drawing.Point(192, 12);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(131, 44);
            this.HeaderLabel.TabIndex = 3;
            this.HeaderLabel.Text = "label3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bookstore_Application.Properties.Resources.Exit_Icon;
            this.pictureBox2.Location = new System.Drawing.Point(916, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.ShowPanel);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Button ShowHistory_Button;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Panel ShowPanel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button TopRated;
    }
}