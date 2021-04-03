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
    public partial class SignupPublisher : Form
    {
        LoginandSignupController logcontroller;
        int Id;
        
        public SignupPublisher()
        {
            InitializeComponent();
            logcontroller = new LoginandSignupController();
            Id = logcontroller.GetcountofUsers() + 1;
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (email.Text == "" || password.Text == "" || Pubname.Text=="" )//validation part
            {
                MessageBox.Show("Please, insert all values");
            }

            else
            {
                int r = logcontroller.InsertUs(email.Text,password.Text,"PubliSher");
                if (r == 0)
                    MessageBox.Show("Your Request is Invalid");

                else 
                { 
                    int x = logcontroller.InsertPub(Id,email.Text,Pubname.Text);
                    if (r == 0)
                        MessageBox.Show("Your Request is Invalid");
                    else {
                        MessageBox.Show("Congratulations You're now a member");
                        this.Hide();
                        LoginForm f = new LoginForm();
                        f.Show();

                    }


                }

            }
        }
    }
    }

