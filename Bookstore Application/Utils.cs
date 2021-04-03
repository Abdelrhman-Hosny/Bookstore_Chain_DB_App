using  System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Bookstore_Application
{
    class Utils
    {
        public static DataTable CrossProduct(int SaleID, int[] BookID)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Sales_ID");
            dt.Columns.Add("Book_ID");
            dt.Columns.Add("Quantity");

            foreach (int i in BookID)
            {
                dt.Rows.Add(SaleID, i, 1);
            }

            return dt;
        }
        public static void AlignNavPanel(Panel NavPanel, Button Btn)
        {

            NavPanel.Height = Btn.Height;
            NavPanel.Left = Btn.Left;
            NavPanel.Top = Btn.Top;
        }

        public static void ShowFormInPanel(Panel ShowPanel, Form frm, string TopText, Label TopLabel)
        {
            TopLabel.Text = TopText;
            ShowPanel.Controls.Clear();

            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.TopMost = true;

            frm.FormBorderStyle = FormBorderStyle.None;
            ShowPanel.Controls.Add(frm);
            frm.Show();
        }

        public static void ShowUCInPanel(Panel ShowPanel, UserControl UC, string TopText, Label TopLabel)
        {
            TopLabel.Text = TopText;
            ShowPanel.Controls.Clear();



            UC.Dock = DockStyle.Fill;

            ShowPanel.Controls.Add(UC);
            UC.Show();


        }

        public static void CheckObjNotNull(object obj)
        {
            string str = Convert.ToString(obj);
            if (String.IsNullOrEmpty(str))
            {
                obj = DBNull.Value;
            }
        }
    }
}
