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
    public partial class Auther : Form
    {
        Empolyee Em;
        public Auther(Empolyee Old)
        {
            InitializeComponent();
            Em = Old;    
        }

        private void Auther_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Em.AddAuthorClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Em.ViewAllAuthor();
        }
    }
}
