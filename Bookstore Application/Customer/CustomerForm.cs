using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bookstore_Application;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Bookstore_Application
{
    
    
    public partial class CustomerForm : Form
    {
        List<int> BooksToBuy;
        int CustomerID;
        CustController ControlObj;
        string mail;
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

        public CustomerForm(string cusmail,string CusId,string CustName)
    {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            ControlObj = new CustController();

            BooksToBuy = new List<int>();
            mail = cusmail;
            CustomerID = Convert.ToInt32(CusId);
            name = CustName;
             
            MailLabel.Text = "#" + CustomerID;


    }

    private void CustomerForm_Load(object sender, EventArgs e)
        {
            // Remeber to Set Navigation panel to the height and make it at the first page

          
            btnMainMenu_Click(sender,e);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            
            Utils.AlignNavPanel(NavigationPanel, SearchBtn);

            CustomerBookSearch_UserControl UC = new CustomerBookSearch_UserControl(BooksToBuy,CustomerID);

            Utils.ShowUCInPanel(this.ShowPanel, UC, "Search Books", HeaderLabel);

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Utils.AlignNavPanel(NavigationPanel, SettingsButton);

            ChangePassword UC = new ChangePassword(mail);

            Utils.ShowUCInPanel(this.ShowPanel, UC, "Change Password", HeaderLabel);

        }

        private void ShowHistory_Button_Click(object sender, EventArgs e)
        {
            Utils.AlignNavPanel(NavigationPanel, ShowHistory_Button);

            CustomerShowSalesHistory UC = new CustomerShowSalesHistory(CustomerID);
            Utils.ShowUCInPanel(this.ShowPanel, UC, "Sales History", HeaderLabel);
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            Utils.AlignNavPanel(NavigationPanel, BuyButton);
            BuyBooksUC UC = new BuyBooksUC(BooksToBuy,CustomerID);
            Utils.ShowUCInPanel(this.ShowPanel, UC, "Buy Books", HeaderLabel);
            // Will add function to take the click on each book searched and add it to that array
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            // Add LogOut Functionality
            this.Hide();
            LoginForm f = new LoginForm();
            f.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().CloseMainWindow();
            Application.Exit();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Utils.AlignNavPanel(NavigationPanel, btnMainMenu);
            //MainMenuForm MainForm = new MainMenuForm();

            //Utils.ShowFormInPanel(this.ShowPanel, MainForm, "Main Menu", HeaderLabel);

            HeaderLabel.Text = "Main Menu";
            this.ShowPanel.Controls.Clear();
            MainMenuForm MainForm = new MainMenuForm(CustomerID.ToString(), mail,name) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            MainForm.FormBorderStyle = FormBorderStyle.None;
            this.ShowPanel.Controls.Add(MainForm);
            MainForm.Show();
        }

        private void TopRated_Click(object sender, EventArgs e)
        {
            Utils.AlignNavPanel(NavigationPanel, TopRated);
            //MainMenuForm MainForm = new MainMenuForm();

            //Utils.ShowFormInPanel(this.ShowPanel, MainForm, "Main Menu", HeaderLabel);

            HeaderLabel.Text = "Top Rated Books";
            this.ShowPanel.Controls.Clear();
            CheckTopRatedBooks MainForm = new CheckTopRatedBooks { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            MainForm.FormBorderStyle = FormBorderStyle.None;
            this.ShowPanel.Controls.Add(MainForm);
            MainForm.Show();
        }
    }
}
