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
    public partial class Employees : Form
    {
        Empolyee Old;
        public Employees(Empolyee Called)
        {
            InitializeComponent();
            Old = Called;
        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Old.AddEmpClicked();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Old.EditEmpClicked();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Old.ViewEmpClicked();
        }
    }
}
