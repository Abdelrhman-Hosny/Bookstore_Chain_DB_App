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
    public partial class AddPurch : Form
    {
        int[] CartPointer;
        int CustomerID;
        EmController ControlObj;
        int BranchID;
        int EmpID;
        public AddPurch(List<int> CartPtr)
        {
            InitializeComponent();
            CartPointer = CartPtr.ToArray();
            ControlObj = new EmController();
        }

        private void AddPurch_Load(object sender, EventArgs e)
        {
            var BookIDs = string.Join(",", CartPointer.Select(x => x.ToString()).ToArray());


            if (String.IsNullOrEmpty(BookIDs))
            {
                DataTable dt = new DataTable();
                BuyGridView.DataSource = dt;
                BuyGridView.Refresh();
                PriceLabel.Text = "0";
                return;
            }
            var BookIDStr = "( " + BookIDs + " )";



            DataTable DisplayTable = ControlObj.DisplayCart(BookIDStr);
            string TotalSalePrice = Convert.ToString(DisplayTable.Compute("Sum(Price)", ""));

            PriceLabel.Text = TotalSalePrice;

            BuyGridView.DataSource = DisplayTable;
            BuyGridView.Refresh();

        }

        private void AddBooks_Click(object sender, EventArgs e)
        {
            CustomerID = Convert.ToInt32(textBox1.Text);
            int NewSaleID = ControlObj.ReturnNextSaleID() + 1;


            var BookIDs = string.Join(",", CartPointer.Select(x => x.ToString()).ToArray());

            if (String.IsNullOrEmpty(BookIDs))
            {
                MessageBox.Show("Cart Is Empty");
                return;

            }
            var BookIDStr = "( " + BookIDs + " )";

            DataTable CartInfo = ControlObj.DisplayCart(BookIDStr);

            string TotalSalePrice = Convert.ToString(CartInfo.Compute("Sum(Price)", ""));


            //Add to Sales History
            ControlObj.AddSaleToHistory(Convert.ToString(NewSaleID), TotalSalePrice, Convert.ToString(CustomerID),BranchID.ToString(),EmpID.ToString());
            //Did The Sold books
            foreach (int id in CartPointer)
            {
                ControlObj.FillSoldBooks(Convert.ToString(NewSaleID), Convert.ToString(id));
            }

            MessageBox.Show("Transaction Complete");
        }

        private void DoubleClickRow(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.BuyGridView.Rows[e.RowIndex];
                int Book_ID = Convert.ToInt32(row.Cells["Book_ID"].Value);
                CartPointer = CartPointer.Where(val => val != Book_ID).ToArray();
                AddPurch_Load(sender, e);

            }
        }
    }
}
