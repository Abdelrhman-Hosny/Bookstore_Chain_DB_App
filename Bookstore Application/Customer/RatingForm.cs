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
    public partial class RatingForm : Form
    {
        string CustomerID, BookID;
        CustController ControlObj;
        public RatingForm(int BID , int CID)
        {
            InitializeComponent();
            CustomerID = Convert.ToString(CID);
            BookID = Convert.ToString(BID);
            ControlObj = new CustController();

        }

        private void RatingForm_Load(object sender, EventArgs e)
        {

        }

        private void RatingButton_Click(object sender, EventArgs e)
        {
            string rate = RatingCombobox.Text;

            if (String.IsNullOrEmpty(rate))
            {
                MessageBox.Show("Please Enter Rating (1 -> 5)");
                return;
            }
            
            // Check if customer has rated this book previously

            if(ControlObj.CheckIfPreviouslyRated(CustomerID,BookID) == 0)
            {
                //Insert New Rating
                ControlObj.AddRating(CustomerID, BookID, rate);
            }
            else
            {
                //Update Rating
                ControlObj.UpdateRating(CustomerID, BookID, rate);

            }
            MessageBox.Show("Rating Added");
            this.Close();

        }
    }
}
