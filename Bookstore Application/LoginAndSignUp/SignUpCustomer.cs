using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_Application
{
    public partial class SignUpCustomer : Form
    {
        int Id;
        LoginandSignupController logcontroller;
        public SignUpCustomer()
        {
            InitializeComponent();
            logcontroller = new LoginandSignupController();
            Id = logcontroller.GetcountofUsers() + 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (email.Text == "" || password.Text == "" || Name.Text == "" || middlename.Text =="" || Lastname.Text== "" || adress.Text=="" )//validation part
            {
                MessageBox.Show("Please, insert all values");
            }

            else
            {
                int r = logcontroller.InsertUs(email.Text, password.Text, "Customer");
                if (r == 0)
                    MessageBox.Show("Your Request is Invalid");

                else
                {
                    int x = logcontroller.InsertCust(Id,Name.Text,middlename.Text,Lastname.Text,adress.Text,comboBox1.Text,email.Text);
                    if (x == 0)
                        MessageBox.Show("Your Request is Invalid");
                    else
                    {
                        MessageBox.Show("Congratulations You're now a member");
                        this.Hide();
                        LoginForm f = new LoginForm();
                        f.Show();

                    }


                }

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.Show();
        }
    }
}
