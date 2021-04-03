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
    public partial class AddBranch : Form
    {
        int id;
        EmController EmC;
        public AddBranch()
        {
            InitializeComponent();
            EmC = new EmController();
            id = EmC.CountBranches() + 1;
        }

        private void AddBranch_Load(object sender, EventArgs e)
        {

        }

        private void AddBooks_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || textBox2.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }

            else
            {
                int r = EmC.AddBranch(id, textBox1.Text, textBox3.Text, Convert.ToInt32(textBox2.Text));
                if (r == 0)
                    MessageBox.Show("Your Request is Invalid");

                else
                {
                    MessageBox.Show("New Branch is Added!");
                }
            }
        }
    }
}
