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
    public partial class Branches : Form
    {
        Empolyee Old;
        public Branches(Empolyee Called)
        {
            InitializeComponent();
            Old = Called;
        }

        private void Branches_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Old.AddBranchClicked();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Old.EditBranchClicked();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Old.ViewAllBranchesClicked();
        }
    }
}
