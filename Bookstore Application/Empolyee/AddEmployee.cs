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
    public partial class AddEmployee : Form
    {
        int BranchID;
        int ManagerID;
        EmController EmC;
        int id;
        string UserType;
        public AddEmployee(int EBranchID , int EManagerID,string type)
        {
            InitializeComponent();
            EmC = new EmController();
            id = EmC.CountEmployees() + 1;
            BranchID = EBranchID;
            ManagerID = EManagerID;
            UserType = type;

            if(UserType == "Manager")
            {
                label9.Visible = false;
                comboBox2.Visible = false;
            }
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void AddBooks_Click(object sender, EventArgs e)
        {
            if (UserType == "Manager")
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || comboBox1.Text == "")//validation part
                {
                    MessageBox.Show("Please, insert all values");
                }
                else
                {
                    int x = EmC.InsertUs(textBox3.Text, textBox4.Text, "Employee");
                    if (x == 0)
                    {
                        MessageBox.Show("Your Request is Invalid");
                    }
                    else
                    {
                        int r = EmC.InsertEmployee(id, textBox1.Text, textBox7.Text, textBox2.Text, textBox6.Text, comboBox1.Text, Convert.ToInt32(textBox5.Text), BranchID, ManagerID, textBox3.Text);
                        if (r == 0)
                            MessageBox.Show("Your Request is Invalid");

                        else
                        {
                            MessageBox.Show("New Employee is Added!");
                        }
                    }

                }
            }
            else
            {

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || comboBox1.Text == ""|| comboBox2.Text=="")//validation part
                {
                    MessageBox.Show("Please, insert all values");
                }
                else
                {
                    int x = EmC.InsertUs(textBox3.Text, textBox4.Text, comboBox2.Text);
                    if (x == 0)
                    {
                        MessageBox.Show("Your Request is Invalid");
                    }
                    else
                    {
                        int r = EmC.InsertEmployee(id, textBox1.Text, textBox7.Text, textBox2.Text, textBox6.Text, comboBox1.Text, Convert.ToInt32(textBox5.Text), BranchID, ManagerID, textBox3.Text);
                        if (r == 0)
                            MessageBox.Show("Your Request is Invalid");

                        else
                        {
                            MessageBox.Show("New "+ comboBox2.Text+ " is Added!");
                        }
                    }

                }

            }

}}}
