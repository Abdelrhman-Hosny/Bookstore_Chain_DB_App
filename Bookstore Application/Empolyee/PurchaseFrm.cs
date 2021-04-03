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
    public partial class PurchaseFrm : Form
    {
        Empolyee Old;
        public PurchaseFrm(Empolyee Called)
        {
            InitializeComponent();
            Old = Called;
        }

        private void PurchaseFrm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Old.AddPurchClicked();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Old.EditPurchClicked();
        }
    }
}
