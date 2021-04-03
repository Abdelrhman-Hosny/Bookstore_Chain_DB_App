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
    public partial class EditPurch : Form
    {
        EmController EmC;

        public EditPurch()
        {
            InitializeComponent();
            EmC = new EmController();
        }

        private void EditPurch_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")//validation part
            {
                MessageBox.Show("Please, insert Sale ID to delete");
            }

            else
            {
                int r = EmC.DeleteSale(Convert.ToInt32(textBox1.Text));
                if (r == 0)
                    MessageBox.Show("Your Request is Invalid");

                else
                {
                    MessageBox.Show("The Sale was Delete Successfully!");
                }

            }
        }
    }
}
