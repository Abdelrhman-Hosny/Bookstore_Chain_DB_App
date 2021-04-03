using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Bookstore_Application
{
    public partial class PublisherForm : Form
    {
        string id;
       
        string email;

        string name;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
             (
                  int nLeftRect,
                  int nTopRect,
                  int nRightRect,
                  int nBottomRect,
                  int nWidthEllipse,
                     int nHeightEllipse

              );
        public PublisherForm(string pid,string pnm, string pemail)
        {

            InitializeComponent();
            id = pid;
            name = pnm;
            email = pemail;
            ID.Text = "#" + id;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlnav.Height = BtnMainMenu.Height;
            pnlnav.Top = BtnMainMenu.Top;
            pnlnav.Left = BtnMainMenu.Left;
            label1.Text = "Main Menu";
            this.panel3.Controls.Clear();
            MainmenuForm mainmenuForm_vrb = new MainmenuForm(id, name, email)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            mainmenuForm_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(mainmenuForm_vrb);
            mainmenuForm_vrb.Show();
        }

      
        private void BtnShowmyrequests_Click(object sender, EventArgs e)
        {
            pnlnav.Height = BtnShowmyrequests.Height;
            pnlnav.Top = BtnShowmyrequests.Top;
            pnlnav.Left = BtnShowmyrequests.Left;
            BtnShowmyrequests.BackColor = Color.FromArgb(46, 51, 73);
            label1.Text = "Previous Requests";
            this.panel3.Controls.Clear();
            PublisherformShowRequests publisherformShowRequests_vrb = new PublisherformShowRequests(id)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            publisherformShowRequests_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(publisherformShowRequests_vrb);
            publisherformShowRequests_vrb.Show();

        }

        private void Btnrequest_Click(object sender, EventArgs e)
        {
            pnlnav.Height = Btnrequest.Height;
            pnlnav.Top = Btnrequest.Top;
            pnlnav.Left = Btnrequest.Left;
            Btnrequest.BackColor = Color.FromArgb(46, 51, 73);
            label1.Text = "Publish A Book";
            this.panel3.Controls.Clear();
            PublisherFormRequest publisherFormRequest_vrb = new PublisherFormRequest(id)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            publisherFormRequest_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(publisherFormRequest_vrb);
            publisherFormRequest_vrb.Show();

        }

        private void BtnShowmyrequests_Leave(object sender, EventArgs e)
        {
            BtnShowmyrequests.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Btnrequest_Leave(object sender, EventArgs e)
        {
            Btnrequest.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void BtnSettings_CLick(object sender, EventArgs e)
        {
            pnlnav.Height = BtnSettings.Height;
            pnlnav.Top = BtnSettings.Top;
            pnlnav.Left = BtnSettings.Left;
            BtnSettings.BackColor = Color.FromArgb(46, 51, 73);
            label1.Text = "Settings";
            this.panel3.Controls.Clear();
            Settingsform settingsform_vrb = new Settingsform(email)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            settingsform_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(settingsform_vrb);
            settingsform_vrb.Show();

        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            pnlnav.Height = BtnMainMenu.Height;
            pnlnav.Top = BtnMainMenu.Top;
            pnlnav.Left = BtnMainMenu.Left;
            BtnMainMenu.BackColor = Color.FromArgb(46, 51, 73);
            label1.Text = "Main Menu";
            this.panel3.Controls.Clear();
            MainmenuForm mainmenuForm_vrb = new MainmenuForm(id, name, email)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            mainmenuForm_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(mainmenuForm_vrb);
            mainmenuForm_vrb.Show();


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            Process.GetCurrentProcess().CloseMainWindow();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.Show();
        }

        private void BtnSettings_Leave(object sender, EventArgs e)
        {
            BtnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnMainMenu_Leave(object sender, EventArgs e)
        {
            BtnMainMenu.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().CloseMainWindow();
            Application.Exit();
        }
    }
}
