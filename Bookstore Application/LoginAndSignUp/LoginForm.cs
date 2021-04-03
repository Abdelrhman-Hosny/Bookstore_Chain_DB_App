using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Bookstore_Application
{
    public partial class LoginForm : Form
    {
        LoginandSignupController logcontroller;
        string password;
        string email;
        string id;
        string usertype;
        string name;

        public LoginForm()
        {
            InitializeComponent();
            logcontroller = new LoginandSignupController();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().CloseMainWindow();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignupPublisher f = new SignupPublisher( );//for admin
            this.Hide();
            f.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            SignUpCustomer f = new SignUpCustomer();//for admin
            this.Hide();
            f.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginemail.Text == "" || loginpassword.Text == "" )//validation part
            {
                MessageBox.Show("Please, insert all values");
            }

            else
            {
                int r = logcontroller.checkuser(loginemail.Text);
                if (r == 0)
                    MessageBox.Show("you're not a user yet sign up now for free !");

                else
                {
                    string x = logcontroller.getpassword(loginemail.Text);
                    if (x != loginpassword.Text)
                        MessageBox.Show("Your Password is Incorrect");
                    else
                    {
                        usertype = logcontroller.getusertype(loginemail.Text);
                        if (usertype == "Publisher")
                        {
                            id = logcontroller.getpubID(loginemail.Text).ToString();
                            name = logcontroller.getpubname(loginemail.Text);
                            email = loginemail.Text;

                            PublisherForm f = new PublisherForm(id,name,email);//for admin
                            f.Show();
                            this.Hide();
                        }
                        else if (usertype == "Admin" || usertype == "Manager" || usertype =="Employee")
                        {
                            id = logcontroller.getEmpID(loginemail.Text).ToString();
                            name = logcontroller.getEmpname(loginemail.Text);
                            email = loginemail.Text;
                            Empolyee f = new Empolyee(email,id,name,usertype);
                            f.Show();
                            this.Hide();
                        }else if (usertype =="Customer")
                        {
                            id = logcontroller.getCustID(loginemail.Text).ToString();
                            name = logcontroller.getCustname(loginemail.Text);
                            email = loginemail.Text;
                            CustomerForm f = new CustomerForm(email,id,name);
                            f.Show();
                            this.Hide();
                        }
                       
                    }
                }
            }
        }
    }
  }

