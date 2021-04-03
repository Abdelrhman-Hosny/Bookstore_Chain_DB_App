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
    public partial class EditEmployee : Form
    {
        EmController EmC;
        public EditEmployee()
        {
            InitializeComponent();
            EmC = new EmController();
        }

        private void EditEmployee_Load(object sender, EventArgs e)
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
                if (comboBox1.Text == "Address")
                {
                    int r = EmC.EditEmpAddress(Convert.ToInt32(textBox1.Text), textBox2.Text);
                    if (r == 0)
                        MessageBox.Show("Your Request is Invalid");
                    else
                    {
                        MessageBox.Show("Address of the Employee is Updated!");
                    }
                }
                else if (comboBox1.Text == "Branch ID")
                {
                    int r = EmC.EditEmpBranchID(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                    if (r == 0)
                        MessageBox.Show("Your Request is Invalid");

                    else
                    {
                        int y = EmC.GetManagerID(Convert.ToInt32(textBox2.Text));
                        int x = EmC.EditEmpManagerID(Convert.ToInt32(textBox1.Text), y);
                        MessageBox.Show("Branch ID of the Employee is Updated!");
                    }
                }
                else if (comboBox1.Text == "Manager ID")
                {
                    int r = EmC.EditEmpManagerID(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                    if (r == 0)
                        MessageBox.Show("Your Request is Invalid");

                    else
                    {
                        int y = EmC.GetBranchID(Convert.ToInt32(textBox2.Text));
                        if(y==0)
                        {
                            MessageBox.Show("ID Entered is Not A Manager!");
                        }
                        else
                        {
                            int x = EmC.EditEmpBranchID(Convert.ToInt32(textBox1.Text), y);
                            MessageBox.Show("Manager ID of the Employee is Updated!");
                        }
                    }
                }
                else if (comboBox1.Text == "Salary")
                {
                    int r = EmC.EditEmpSalary(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                    if (r == 0)
                        MessageBox.Show("Your Request is Invalid");

                    else
                    {
                        MessageBox.Show("Salary of the Employee is Updated!");
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
                int r = EmC.DeleteEmployee(Convert.ToInt32(textBox1.Text));
                if (r == 0)
                    MessageBox.Show("Your Request is Invalid");

                else
                {
                    MessageBox.Show("The Employee was Delete Successfully!");
                }

            }
        }
    }
}
