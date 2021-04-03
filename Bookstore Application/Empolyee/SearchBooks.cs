using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace Bookstore_Application
{
    public partial class SearchBooks : Form
    {
        int EmpID;
        List<int> CartPointer;
        EmController ControlObj;
        public SearchBooks(List<int> CartPtr)
        {
            InitializeComponent();
            CartPointer = CartPtr;
            ControlObj = new EmController();
            
            
        }

        private void SearchBooks_Load(object sender, EventArgs e)
        {

        }
        private void AddToCart(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                int Book_ID = Convert.ToInt32(row.Cells["Book_ID"].Value);
                if (!CartPointer.Contains(Book_ID))
                {
                    CartPointer.Add(Book_ID);
                    MessageBox.Show("Book Added to Cart");
                }
                else MessageBox.Show("Book Already in Cart");
            }
        }

        private void GenreComboBox_Click(object sender, EventArgs e)
        {
            GenreComboBox.DataSource = ControlObj.getGenres();
            GenreComboBox.DisplayMember = "Genre";
        }

        private void LanguageComboBox_Click(object sender, EventArgs e)
        {
            LanguageComboBox.DataSource = ControlObj.getLangauges();
            LanguageComboBox.DisplayMember = "Book_Language";
        }

        private void AddBooks_Click(object sender, EventArgs e)
        {
            object BookName = BookName_TextBox.Text;
            Utils.CheckObjNotNull(BookName);

            object Genre = Convert.ToString(GenreComboBox.Text);
            Utils.CheckObjNotNull(Genre);

            object Author = AuthorTextBox.Text;
            Utils.CheckObjNotNull(Author);

            object Language = Convert.ToString(LanguageComboBox.Text);
            Utils.CheckObjNotNull(Language);

            object Publisher = PublisherTextBox.Text;
            Utils.CheckObjNotNull(Publisher);

            string SortBy = Convert.ToString(Sort_Combobox.Text);
            string SortOrder = Convert.ToString(SortOrder_Combobox.Text);
            if (String.IsNullOrEmpty(SortOrder) || SortOrder.StartsWith("A")) SortOrder = "asc";
            else SortOrder = "desc";

            DataTable dt = ControlObj.GetSearchedBook(BookName, Genre, Author, Language, Publisher);

            if (!(SortBy == "None") && !(String.IsNullOrEmpty(SortBy)))
            {

                if (SortBy == "Name") SortBy = "BookName";

                dt.DefaultView.Sort = String.Concat(SortBy, " ", SortOrder);
                dt = dt.DefaultView.ToTable();

            }
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

        }
    }
}
