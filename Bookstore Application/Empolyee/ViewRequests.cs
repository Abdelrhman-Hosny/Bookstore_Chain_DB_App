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
    public partial class ViewRequests : Form
    {
        EmController EmC;
        int Request_ID=-1;
        int BookID;
        int AuthorID;
        string BookName;
        string BookDesc;
        string BookGenre;
        string Book_langauge;
        int Book_price;
        string AuthorName;
        string AuthorLname;
        int Publisher_ID;
        public ViewRequests()
        {
            InitializeComponent();
        }

        private void ViewRequests_Load(object sender, EventArgs e)
        {
            EmC = new EmController();
            DataTable dt = EmC.ViewAllRequests();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                Request_ID = Convert.ToInt32(row.Cells["Request_ID"].Value);
                BookName = row.Cells["Book_Name"].Value.ToString();
                BookDesc = row.Cells["Book_Description"].Value.ToString();
                BookGenre = row.Cells["Book_Genre"].Value.ToString();
                Book_langauge = row.Cells["Book_Language"].Value.ToString();
                AuthorName = row.Cells["Author_Name"].Value.ToString();
                AuthorLname = row.Cells["Author_LName"].Value.ToString();
                Book_price = Convert.ToInt32(row.Cells["Book_Price"].Value);
                Publisher_ID = Convert.ToInt32(row.Cells["Publisher_ID"].Value);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                if(Request_ID == -1)
                {
                    MessageBox.Show("Please, Click a Request!");
                }
                else
                {
                    EmC.UpdateRequestStatues(Request_ID, "Accept");
                    EmC = new EmController();
                    BookID = EmC.CountBooks() + 1;
                    int AuthorID = EmC.GetAuthorID(AuthorName, AuthorLname);
                    if (AuthorID == 0)
                    {
                        AuthorID = EmC.CountAuther() + 1;
                        int x = EmC.AddAuthor(AuthorID, AuthorName, AuthorLname);
                    }
                    int r = EmC.InsertBook(BookID, BookName, Book_langauge, BookGenre, Book_price, Convert.ToInt32(textBox1.Text), BookDesc, 0, AuthorID, Publisher_ID);
                    DataTable dt = EmC.ViewAllRequests();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    Request_ID = -1;
                }
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Request_ID == -1)
            {
                MessageBox.Show("Please, Click a Request!");
            }
            else
            {
                EmC.UpdateRequestStatues(Request_ID, "Reject");
                EmC = new EmController();
                DataTable dt = EmC.ViewAllRequests();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                Request_ID = -1;
            }
         
        }
    }
}
