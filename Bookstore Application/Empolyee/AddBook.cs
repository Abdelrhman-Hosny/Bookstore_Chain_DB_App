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
    public partial class AddBook : Form
    {
        EmController EmC;
        int id;
        public AddBook()
        {
            InitializeComponent();
            EmC = new EmController();
            id = EmC.CountBooks() + 1;
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void AddBooks_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }

            else
            {
                int r = EmC.InsertBook(id,textBox1.Text,textBox4.Text,textBox3.Text,Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox5.Text),textBox2.Text,0, Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text));
                if (r == 0)
                    MessageBox.Show("Your Request is Invalid");

                else
                {
                   MessageBox.Show("New Book is Added!");
                }

            }
        }
    }
}
