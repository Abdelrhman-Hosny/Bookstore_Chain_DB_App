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
    public partial class ViewAllEmp : Form
    {
        public ViewAllEmp()
        {
            InitializeComponent();
        }

        private void ViewAllEmpEmp_Load(object sender, EventArgs e)
        {

        }

        private void ViewAllEmp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookstoreDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.bookstoreDataSet.Employees);

        }
    }
}
