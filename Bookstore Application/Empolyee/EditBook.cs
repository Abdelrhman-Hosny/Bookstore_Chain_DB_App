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
    public partial class EditBook : Form
    {
        EmController EmC;
        public EditBook()
        {
            EmC = new EmController();
            InitializeComponent();
        }

        private void EditBook_Load(object sender, EventArgs e)
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
                    int r = EmC.EditBookPrice(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                    if (r == 0)
                        MessageBox.Show("Your Request is Invalid");
                    else
                    {
                        MessageBox.Show("Price of the Book is Updated!");
                    }
                }
                else if (comboBox1.Text == "Manager ID")
                {
                    int r = EmC.EditQuantityPrice(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                    if (r == 0)
                        MessageBox.Show("Your Request is Invalid");

                    else
                    {
                        MessageBox.Show("Quantity of the Book is Updated!");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")//validation part
            {
                MessageBox.Show("Please, insert Book ID to delete");
            }

            else
            {
                int r = EmC.DeleteBook(Convert.ToInt32(textBox1.Text));
                if (r == 0)
                    MessageBox.Show("Your Request is Invalid");

                else
                {
                    MessageBox.Show("The Book was Delete Successfully!");
                }

            }

        }
    }
}
