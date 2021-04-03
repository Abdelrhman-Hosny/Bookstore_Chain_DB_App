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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm(string id,string mail,string name)
        {
            InitializeComponent();
            label5.Text = name;
            label9.Text ="#"+ id;
            label10.Text = mail;
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
