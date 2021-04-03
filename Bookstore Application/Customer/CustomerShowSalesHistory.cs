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
    public partial class CustomerShowSalesHistory : UserControl
    {
        int Customer_ID;
        CustController ControlObj;
        public CustomerShowSalesHistory(int CustID)
        {
            InitializeComponent();
            Customer_ID = CustID;
            ControlObj = new CustController();

           
        }

        private void CustomerShowSalesHistory_Load(object sender, EventArgs e)
        {
            DataTable dt = ControlObj.GetSalesHistory(Customer_ID);
            SalesHistoryGridView.DataSource = dt;
            SalesHistoryGridView.Refresh();

        }
        private void SalesHistoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.SalesHistoryGridView.Rows[e.RowIndex];
                int Book_ID = Convert.ToInt32(row.Cells["Book_ID"].Value);

                RatingForm Frm = new RatingForm(Book_ID, Customer_ID);
                Frm.Show();
            }
        }
    }
}
