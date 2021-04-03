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
    public partial class AddAuthor : Form
    {
        int id;
        EmController EmC;
        public AddAuthor()
        {
            InitializeComponent();
            EmC = new EmController();
            id = EmC.CountAuther();
        }

        private void AddAuthor_Load(object sender, EventArgs e)
        {

        }

        private void AddBooks_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" )//validation part
            {
                MessageBox.Show("Please, insert all values");
            }

            else
            {
                int x = EmC.AddAuthor(id,textBox1.Text, textBox2.Text);
                if (x == 0)
                {
                    MessageBox.Show("Your Request is Invalid");
                }
                else
                {
                  
                    MessageBox.Show("New Author is Added!");

                }

            }
        }
    }
}
