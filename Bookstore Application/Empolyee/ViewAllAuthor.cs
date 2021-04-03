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
    public partial class ViewAllAuthor : Form
    {
        public ViewAllAuthor()
        {
            InitializeComponent();
        }

        private void ViewAllAuthor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookstoreDataSet6.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.bookstoreDataSet6.Authors);

        }
    }
}
