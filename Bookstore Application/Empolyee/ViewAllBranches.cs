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
    public partial class ViewAllBranches : Form
    {
        public ViewAllBranches()
        {
            InitializeComponent();
        }

        private void ViewAllBranches_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookstoreDataSet5.Branches' table. You can move, or remove it, as needed.
            this.branchesTableAdapter1.Fill(this.bookstoreDataSet5.Branches);
            // TODO: This line of code loads data into the 'bookstoreDataSet4.Branches' table. You can move, or remove it, as needed.
            this.branchesTableAdapter.Fill(this.bookstoreDataSet4.Branches);

        }
    }
}
