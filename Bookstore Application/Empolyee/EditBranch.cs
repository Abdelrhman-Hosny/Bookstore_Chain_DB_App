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
    public partial class EditBranch : Form
    {
        EmController EmC;
        public EditBranch()
        {
            InitializeComponent();
            EmC = new EmController();
        }

        private void EditBranch_Load(object sender, EventArgs e)
        {

        }

        private void AddBooks_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }

            else
            {
                if (comboBox1.Text == "Name")
                {
                    int r = EmC.EditBranchName(Convert.ToInt32(textBox1.Text), textBox2.Text);
                    if (r == 0)
                        MessageBox.Show("Your Request is Invalid");
                    else
                    {
                        MessageBox.Show("Name of the Branch is Updated!");
                    }
                }
                else if (comboBox1.Text == "Manager ID")
                {
                    int r = EmC.EditBranchManager(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                    int y = EmC.EditManagerCascasde(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox1.Text));
                    if (r == 0)
                        MessageBox.Show("Your Request is Invalid");

                    else
                    {
                        MessageBox.Show("Manager of the Branch is Updated!");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")//validation part
            {
                MessageBox.Show("Please, insert Branch ID to delete");
            }

            else
            {
                int r = EmC.DeleteBranch(Convert.ToInt32(textBox1.Text));
                if (r == 0)
                    MessageBox.Show("Your Request is Invalid");

                else
                {
                    MessageBox.Show("The Branch was Delete Successfully!");
                }

            }
        }
    }
}
