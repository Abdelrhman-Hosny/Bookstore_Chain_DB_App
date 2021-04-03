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
    public partial class TotalReports : Form
    {
        Empolyee old;
        public TotalReports(Empolyee Called)
        {
            InitializeComponent();
            old = Called;
        }

        private void TotalReports_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            old.BranchInfoReports();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            old.TotalSaleReports();
        }
    }
}
