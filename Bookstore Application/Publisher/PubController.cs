using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Bookstore_Application
{
    public class PubController
    {
        DBManager dbMan;
        public PubController()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public int InsertRequest(int rid,string pubid,string Bookdes, string Booknm , string BookGen,string BookLan , int price, string Authorfname, string AuthorLastName)
        {

            string StoredProcedureName = StoredProcedures.InsertRequest;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Requestid", rid);
            Parameters.Add("@PubLisherID", pubid);
            Parameters.Add("@BookDescription", Bookdes);
            Parameters.Add("@BookName", Booknm);
            Parameters.Add("@BookGenre", BookGen);
            Parameters.Add("@BookLanguage", BookLan);
            Parameters.Add("@BookPrice", price);
            Parameters.Add("@Authorfname", Authorfname);
            Parameters.Add("@Authorlname", AuthorLastName);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertStatus(int rid,string name)
        {

            string StoredProcedureName = StoredProcedures.InsertRequeststatus;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Requestid", rid);
            Parameters.Add("@RequestStatus", name);
            


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable SelectRequests(string Pubid)
        {

            String StoredProcedureName = StoredProcedures.ViewRequests;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PublisherId ", Pubid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public int Getcountofrequests()
        {
            string query = "select Count(*) from Requests_History ";
            return (int)dbMan.ExecuteScalar(query);
        }
        public string GetPWFromMail(string Email)
        {
            string StrProc = StoredProcedures.GetPWFromMail;


            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Email", Email);

            return Convert.ToString(dbMan.ExecuteScalar(StrProc, Parameters));

        }

        public int UpdatePassword(string Email, string Password)
        {
            string StrProc = StoredProcedures.ChangePW;


            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Email", Email);
            Parameters.Add("@PassW", Password);

            return dbMan.ExecuteNonQuery(StrProc, Parameters);
        }


    }
}