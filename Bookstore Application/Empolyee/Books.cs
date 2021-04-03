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
    public partial class Books : Form
    {
        Empolyee Old;
        public Books(Empolyee Called)
        {
            InitializeComponent();
            Old = Called;
        }

        private void Books_Load(object sender, EventArgs e)
        {

        }

        private void SearchBooks_Click(object sender, EventArgs e)
        {
            Old.SearchBooksClicked();
        }

        private void AddBooks_Click(object sender, EventArgs e)
        {
            Old.AddBooksClicked();
        }

        private void EditBooks_Click(object sender, EventArgs e)
        {
            Old.EditBooksClicked();
        }
    }
}
