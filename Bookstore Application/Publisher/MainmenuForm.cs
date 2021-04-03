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
    public partial class MainmenuForm : Form
    {
        public MainmenuForm(string pid, string pnm, string pemail)
        {
            InitializeComponent();
            PublisherName.Text = pnm;
            PublisherID.Text = "#"+pid;
            Publisheremail.Text = pemail;
        }
    }
}
