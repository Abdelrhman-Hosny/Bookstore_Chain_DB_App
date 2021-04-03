
namespace Bookstore_Application
{
    partial class Settingsform
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ChangePWButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmPW_Txtbox = new System.Windows.Forms.TextBox();
            this.NewPW_Txtbox = new System.Windows.Forms.TextBox();
            this.OldPW_Txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(14, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Confirm Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label4.Location = new System.Drawing.Point(30, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "New Password";
            // 
            // ChangePWButton
            // 
            this.ChangePWButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ChangePWButton.FlatAppearance.BorderSize = 0;
            this.ChangePWButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePWButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.ChangePWButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ChangePWButton.Location = new System.Drawing.Point(533, 380);
            this.ChangePWButton.Name = "ChangePWButton";
            this.ChangePWButton.Size = new System.Drawing.Size(186, 40);
            this.ChangePWButton.TabIndex = 20;
            this.ChangePWButton.Text = "Change";
            this.ChangePWButton.UseVisualStyleBackColor = false;
            this.ChangePWButton.Click += new System.EventHandler(this.ChangePWButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(37, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Old Password";
            // 
            // ConfirmPW_Txtbox
            // 
            this.ConfirmPW_Txtbox.Location = new System.Drawing.Point(200, 171);
            this.ConfirmPW_Txtbox.Name = "ConfirmPW_Txtbox";
            this.ConfirmPW_Txtbox.Size = new System.Drawing.Size(248, 22);
            this.ConfirmPW_Txtbox.TabIndex = 18;
            // 
            // NewPW_Txtbox
            // 
            this.NewPW_Txtbox.Location = new System.Drawing.Point(200, 114);
            this.NewPW_Txtbox.Name = "NewPW_Txtbox";
            this.NewPW_Txtbox.Size = new System.Drawing.Size(248, 22);
            this.NewPW_Txtbox.TabIndex = 17;
            // 
            // OldPW_Txtbox
            // 
            this.OldPW_Txtbox.Location = new System.Drawing.Point(200, 56);
            this.OldPW_Txtbox.Name = "OldPW_Txtbox";
            this.OldPW_Txtbox.Size = new System.Drawing.Size(248, 22);
            this.OldPW_Txtbox.TabIndex = 16;
            // 
            // Settingsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChangePWButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmPW_Txtbox);
            this.Controls.Add(this.NewPW_Txtbox);
            this.Controls.Add(this.OldPW_Txtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settingsform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ChangePWButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ConfirmPW_Txtbox;
        private System.Windows.Forms.TextBox NewPW_Txtbox;
        private System.Windows.Forms.TextBox OldPW_Txtbox;
    }
}