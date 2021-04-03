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


    public partial class Empolyee : Form
    {
        List<int> BooksToBuy;
        EmController Em;
        string mail;
        string id;
        string name;
        string branchID;
        string type;
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
        public Empolyee(string Email, string eid, string ename, string UserType)
        {
            InitializeComponent();
            Em = new EmController();
            type = UserType;
            mail = Email;
            id = eid;
            name = ename;
            branchID = Em.GetBranchIDfromEmpTable(Convert.ToInt32(id)).ToString();
            label1.Text = "#" + id;
            label2.Text = UserType;
            if (UserType == "Employee")
            {
                btnEmployees.Visible = false;
                btnViewRequests.Visible = false;
                btnBranches.Visible = false;
                btnReports.Visible = false;
            } else if (UserType == "Manager")
            {
                btnReports.Visible = false;
                btnViewRequests.Visible = false;
                btnBranches.Visible = false;
                label2.Left = 59;
            }
            else
            {
                label2.Left = 66;
            }



            BooksToBuy = new List<int>();
            
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = btnMainMenu.Height;
            PnlNav.Top = btnMainMenu.Top;
            PnlNav.Left = btnMainMenu.Left;
            //btnMainMenu.BackColor = Color.FromArgb(46, 51, 73);
            IbITitle.Text = "Main Menu";
            this.PnlFormLoader.Controls.Clear();
            MainMenuForm MainForm = new MainMenuForm(id, mail, name) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true } ;
            MainForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(MainForm);
            MainForm.Show();

        }
        


        private void Empolyee_Load(object sender, EventArgs e)
        {

        }

        private void btnViewPurchasingHistory_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnViewPurchasingHistory.Height;
            PnlNav.Top = btnViewPurchasingHistory.Top;
            PnlNav.Left = btnViewPurchasingHistory.Left;
            btnViewPurchasingHistory.BackColor = Color.FromArgb(46,51,73);


            IbITitle.Text = "Purchasing History";
            this.PnlFormLoader.Controls.Clear();
            PurchHistoryForm HistoryForm = new PurchHistoryForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            HistoryForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(HistoryForm);
            HistoryForm.Show();



        }
        private void btnBooks_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnBooks.Height;
            PnlNav.Top = btnBooks.Top;
            PnlNav.Left = btnBooks.Left;
            btnBooks.BackColor = Color.FromArgb(46, 51, 73);

            IbITitle.Text = "Books";
            this.PnlFormLoader.Controls.Clear();
            Books Frm = new Books(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Frm);
            Frm.Show();

        }
        public void SearchBooksClicked()
        {
            IbITitle.Text = "Search Books";
            this.PnlFormLoader.Controls.Clear();
            SearchBooks Frm = new SearchBooks(BooksToBuy) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Frm);
            Frm.Show();

        }

        public void EditBooksClicked()
        {
            IbITitle.Text = "Edit Books";
            this.PnlFormLoader.Controls.Clear();
            EditBook Frm = new EditBook { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Frm);
            Frm.Show();

        }

        public void AddBooksClicked()
        {
            IbITitle.Text = "Add Books";
            this.PnlFormLoader.Controls.Clear();
            AddBook Frm = new AddBook { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Frm);
            Frm.Show();

        }


        private void btnNewPurchase_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnNewPurchase.Height;
            PnlNav.Top = btnNewPurchase.Top;
            PnlNav.Left = btnNewPurchase.Left;
            btnNewPurchase.BackColor = Color.FromArgb(46, 51, 73);

            IbITitle.Text = "Purchase";
            this.PnlFormLoader.Controls.Clear();
            PurchaseFrm Frm = new PurchaseFrm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Frm);
            Frm.Show();
        }
        public void AddPurchClicked()
        {
            IbITitle.Text = "Add Purchase";
            this.PnlFormLoader.Controls.Clear();
            AddPurch Frm = new AddPurch(BooksToBuy) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Frm);
            Frm.Show();

        }
        public void EditPurchClicked()
        {
            IbITitle.Text = "Edit Purchase";
            this.PnlFormLoader.Controls.Clear();
            EditPurch Frm = new EditPurch { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Frm);
            Frm.Show();

        }


        private void btnEmployees_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnEmployees.Height;
            PnlNav.Top = btnEmployees.Top;
            PnlNav.Left = btnEmployees.Left;
            btnEmployees.BackColor = Color.FromArgb(46, 51, 73);

            IbITitle.Text = "Employees";
            this.PnlFormLoader.Controls.Clear();
            Employees Frm = new Employees(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Frm);
            Frm.Show();
        }

        public void AddEmpClicked()
        {
            IbITitle.Text = "Add Employee";
            this.PnlFormLoader.Controls.Clear();
            AddEmployee Frm = new AddEmployee(Convert.ToInt32(id), Convert.ToInt32(branchID),type) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Frm);
            Frm.Show();

        }

        public void EditEmpClicked()
        {
            IbITitle.Text = "Edit Employee";
            this.PnlFormLoader.Controls.Clear();
            EditEmployee Frm = new EditEmployee { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Frm);
            Frm.Show();

        }
        public void ViewEmpClicked()
        {
            IbITitle.Text = "View Employee";
            this.PnlFormLoader.Controls.Clear();
            ViewAllEmp Frm = new ViewAllEmp { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Frm);
            Frm.Show();

        }
        private void btnBranches_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnBranches.Height;
            PnlNav.Top = btnBranches.Top;
            PnlNav.Left = btnBranches.Left;
            btnBranches.BackColor = Color.FromArgb(46, 51, 73);

            IbITitle.Text = "Branches";
            this.PnlFormLoader.Controls.Clear();
            Branches MainForm = new Branches(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            MainForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(MainForm);
            MainForm.Show();
        }
        public void AddBranchClicked()
        {
            IbITitle.Text = "Add Branch";
            this.PnlFormLoader.Controls.Clear();
            AddBranch Frm = new AddBranch { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Frm);
            Frm.Show();

        }
        public void EditBranchClicked()
        {
            IbITitle.Text = "Edit Branch";
            this.PnlFormLoader.Controls.Clear();
            EditBranch Frm = new EditBranch { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Frm);
            Frm.Show();

        }
        public void ViewAllBranchesClicked()
        {
            IbITitle.Text = "View Branches";
            this.PnlFormLoader.Controls.Clear();
            ViewAllBranches Frm = new ViewAllBranches { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Frm);
            Frm.Show();

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnSettings.Height;
            PnlNav.Top = btnSettings.Top;
            PnlNav.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);

            IbITitle.Text = "Settings";
            this.PnlFormLoader.Controls.Clear();
            Setting Frm = new Setting(mail) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Frm);
            Frm.Show();
        }
        private void btnViewRequests_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnViewRequests.Height;
            PnlNav.Top = btnViewRequests.Top;
            PnlNav.Left = btnViewRequests.Left;
            btnViewRequests.BackColor = Color.FromArgb(46, 51, 73);


            IbITitle.Text = "View Requests";
            this.PnlFormLoader.Controls.Clear();
            ViewRequests Frm = new ViewRequests() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Frm);
            Frm.Show();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnLogOut.Height;
            PnlNav.Top = btnLogOut.Top;
            PnlNav.Left = btnLogOut.Left;
            btnLogOut.BackColor = Color.FromArgb(46, 51, 73);
            this.Hide();
            LoginForm f = new LoginForm();
            f.Show();
        }
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnMainMenu.Height;
            PnlNav.Top = btnMainMenu.Top;
            PnlNav.Left = btnMainMenu.Left;
            btnMainMenu.BackColor = Color.FromArgb(46, 51, 73);
            
            IbITitle.Text = "Main Menu";
            this.PnlFormLoader.Controls.Clear();
            MainMenuForm MainForm = new MainMenuForm(id,mail,name) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true } ;
            MainForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(MainForm);
            MainForm.Show();
        }
       


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().CloseMainWindow();
            Application.Exit();
        }

        private void btnViewPurchasingHistory_Leave(object sender, EventArgs e)
        {
            btnViewPurchasingHistory.BackColor = Color.FromArgb(24,30,54);
        }

        private void btnBooks_Leave(object sender, EventArgs e)
        {
            btnBooks.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnNewPurchase_Leave(object sender, EventArgs e)
        {
            btnNewPurchase.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnEmployees_Leave(object sender, EventArgs e)
        {
            btnEmployees.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnViewRequests_Leave(object sender, EventArgs e)
        {
            btnViewRequests.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnMainMenu_Leave(object sender, EventArgs e)
        {
            btnMainMenu.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnLogOut_Leave(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.FromArgb(24, 30, 54);
        }

      

        private void button1_Leave(object sender, EventArgs e)
        {
            btnBranches.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnAuthor.Height;
            PnlNav.Top = btnAuthor.Top;
            PnlNav.Left = btnAuthor.Left;
            btnAuthor.BackColor = Color.FromArgb(46, 51, 73);

            IbITitle.Text = "Author";
            this.PnlFormLoader.Controls.Clear();
            Auther MainForm = new Auther(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            MainForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(MainForm);
            MainForm.Show();
        }
        public void ViewAllAuthor()
        {
            IbITitle.Text = "View All Author";
            this.PnlFormLoader.Controls.Clear();
            ViewAllAuthor MainForm = new ViewAllAuthor() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            MainForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(MainForm);
            MainForm.Show();
        }
        public void AddAuthorClick()
        {
            IbITitle.Text = "Add Author";
            this.PnlFormLoader.Controls.Clear();
            AddAuthor MainForm = new AddAuthor() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            MainForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(MainForm);
            MainForm.Show();
        }



        private void btnAuthor_Leave(object sender, EventArgs e)
        {
            btnAuthor.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnReports.Height;
            PnlNav.Top = btnReports.Top;
            PnlNav.Left = btnReports.Left;
            btnReports.BackColor = Color.FromArgb(46, 51, 73);

            IbITitle.Text = "Reports";
            this.PnlFormLoader.Controls.Clear();
            TotalReports MainForm = new TotalReports(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            MainForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(MainForm);
            MainForm.Show();
        }
        
        public void BranchInfoReports()
        {
            IbITitle.Text = "Branches Info";
            this.PnlFormLoader.Controls.Clear();
            Reports MainForm = new Reports { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            MainForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(MainForm);
            MainForm.Show();
        }
        public void TotalSaleReports()
        {
            IbITitle.Text = "Total Sales Per Year";
            this.PnlFormLoader.Controls.Clear();
            TotalSales MainForm = new TotalSales { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            MainForm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(MainForm);
            MainForm.Show();
        }



        private void btnReports_Leave(object sender, EventArgs e)
        {
            btnReports.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
