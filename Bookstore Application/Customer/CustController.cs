using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Bookstore_Application
{
    class CustController
    {
            DBManager dbMan;

            public CustController()
            {
                dbMan = new DBManager();
            }



            public int AddSaleToHistory(string Sale_ID,string SalePrice , string CustomerID)
              {
            string query = "Insert Into Sales_History Values(" + Sale_ID + " , " + SalePrice+ ",0,null, " + CustomerID + " ,getdate() )";

            return dbMan.ExecuteNonQuery(query);
            }
            public int FillSoldBooks(string SaleID , string BookID,string Quantity = "1")
            {

            string query = "INSERT INTO SoldBooks Values(" +SaleID+ " , " +BookID+ " , " +Quantity + " );";
            return dbMan.ExecuteNonQuery(query);
            }
            public DataTable GetSalesHistory(int CID)
            {
            string StrProc = CustStoredProc.ShowCustSales;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@CustomerID", CID);

            return dbMan.ExecuteReader(StrProc, Parameters);

            }

        public int GetIDFromEmail(string Email)
        {
            string StrProc = CustStoredProc.GetIDFromMail;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Email", Email);

            return Convert.ToInt32(dbMan.ExecuteScalar(StrProc,Parameters));
        }

        public string GetPWFromMail(string Email)
        {
            string StrProc = CustStoredProc.GetPWFromMail;


            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Email", Email);

            return Convert.ToString(dbMan.ExecuteScalar(StrProc, Parameters));

        }

        public int UpdatePassword(string Email , string Password)
        {
            string StrProc = CustStoredProc.ChangePW;


            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Email", Email);
            Parameters.Add("@PassW", Password);

            return dbMan.ExecuteNonQuery(StrProc, Parameters); 
        }

        public int ReturnNextSaleID()
        {

            string query = "Select COUNT(*) From Sales_History;";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public DataTable DisplayCart(string BookIDs)
        {
          
            string query = "Select Book_ID , BookName ,AuthoRS.Fname , Authors.LastName , Publishers.PublisherName, Book_Language , Genre , Price , Rating " +
                "from Books join Authors on Books.Author_ID = Authors.Author_ID join Publishers on Books.Publisher_ID = Publishers.Publisher_ID " +
                "where (Books.Book_ID in " + BookIDs + " AND Quantity != 0 );";

            return dbMan.ExecuteReader(query);
        }

        public DataTable getGenres()
        {
            string query = "select distinct(genre) from books;";

            return dbMan.ExecuteReader(query);
        }

        public DataTable getLangauges()
        {
            string query = "select distinct(Book_Language) from books;";

            return dbMan.ExecuteReader(query);
        }

        public int AddRating(string cid , string bid , string rating)
        {
            string query = "Insert Into CustomerRating Values( " + cid + " , " + bid + " , " + rating + " ) ;";

            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateRating(string cid, string bid, string rating)
        {
            string query = "Update CustomerRating Set Rating = " + rating + " where CustomerID = " + cid + " AND Book_ID = " +bid + " ;";


            return dbMan.ExecuteNonQuery(query);
        }


        public int CheckIfPreviouslyRated(string CusID , string BID)
        {
            string query = "Select Count(*) from CustomerRating where CustomerID = " + CusID + " AND Book_ID = " + BID + " ;";

            return Convert.ToInt32( dbMan.ExecuteScalar(query) ) ;
        }

        public DataTable GetSearchedBook(object BookName,object Genre,object Author,object Language,object Publisher)
        {

            string StrProc = CustStoredProc.CustSearch;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Name", BookName);
            Parameters.Add("@Author", Author);
            Parameters.Add("@Genre", Genre);
            Parameters.Add("@LANG", Language);
            Parameters.Add("@Publisher", Publisher);

            return dbMan.ExecuteReader(StrProc, Parameters);
        }
        public int DecrementBoughtBooks(string BookIDs)
        {
            string query = "update Books set Quantity = Quantity - 1 where Book_ID in " + BookIDs + " ;";
            return dbMan.ExecuteNonQuery(query);
        }

        public void TerminateConnection()
            {
                dbMan.CloseConnection();
            }
        }
    }

