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
    public partial class PublisherFormRequest : Form
    {
        PubController PbController;
        int count ;
        string id;

        public PublisherFormRequest(string i)
        {    
            InitializeComponent();

            PbController = new PubController();

             count = PbController.Getcountofrequests()  +1 ;

            id = i;

           
           


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (DesriptionTextBox.Text == "" || PriceTextBox.Text == "" || GenreTextBox.Text == "" || LanguageTextBox.Text == "" || NameTextBox.Text=="" )//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
       
            else
            {
                int r = PbController.InsertRequest(count,id,DesriptionTextBox.Text, NameTextBox.Text, GenreTextBox.Text, LanguageTextBox.Text, Convert.ToInt32(PriceTextBox.Text), textBox1.Text, textBox2.Text);
                if (r == 0)
                    MessageBox.Show("Your Request is Invalid");

                else

                    PbController.InsertStatus(count ,"pending");

                    MessageBox.Show("Your Request is now Pending for Approval ! ");
            }
        }
    }
}
