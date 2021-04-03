using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Bookstore_Application
{
    public class LoginandSignupController
    {
        DBManager dbMan;
        public LoginandSignupController()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public int InsertUs(string email,string pass,string user)
        {

            string StoredProcedureName = StoredProcedures.Insertuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@UserEmail", email);
            Parameters.Add("@UserPassword", pass);
            Parameters.Add("@Usert", user);
            
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertPub(int pid,  string pbemail,string pbname)
        {

            string StoredProcedureName = StoredProcedures.InsertPublisher;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Pub_Id", pid);
            Parameters.Add("@Pub_Email", pbemail);
            Parameters.Add("@Pub_name", pbname);




            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertCust(int cid, string cfname, string cmname, string clname, string cadress, string cgender, string cemail)
        {

            string StoredProcedureName = StoredProcedures.InsertCustomer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Cust_ID", cid);
            Parameters.Add("@Cust_Fname", cfname);
            Parameters.Add("@Cust_Mname", cmname);
            Parameters.Add("@Cust_Lname", clname);
            Parameters.Add("@Cust_Adress", cadress);
            Parameters.Add("@Cust_Gender", cgender);
            Parameters.Add("@Cust_Email", cemail);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int GetcountofUsers()
        {
            string query = "select Count(*) from Login_Info ";
            return (int)dbMan.ExecuteScalar(query);
        }
        public string getpassword(string email)
        {
            string query = "select Passw from Login_info where email =  '" + email + "'; ";
            return (string)dbMan.ExecuteScalar(query);
        }
        public int checkuser(string email)
        {
            string query = "select Count(Email) from Login_Info where email =  '" + email + "'; ";
            return (int)dbMan.ExecuteScalar(query);
        }
        public string getusertype(string email)
        {
            string query = "select UserType from Login_info where email =  '" + email + "'; ";
            return (string)dbMan.ExecuteScalar(query);
        }

        public int getpubID(string email)
        {
            string query = "select Publisher_ID from Publishers,Login_info where Email= Publisher_Email and Publisher_Email =  '" + email + "'; ";
            return (int)dbMan.ExecuteScalar(query);
        }
        public string getpubname(string email)
        {
            string query = "select PublisherName from Publishers,Login_info where Email= Publisher_Email and  Publisher_Email ='" + email + "'; ";
            return (string)dbMan.ExecuteScalar(query);
        }
        public int getEmpID(string email)
        {
            string query = "select Emp_ID from Employees,Login_info where Email= Emp_Email and Emp_Email =  '" + email + "'; ";
            return (int)dbMan.ExecuteScalar(query);
        }
        public string getEmpname(string email)
        {
            string query = "select Fname from Employees,Login_info where Email= Emp_Email and  Emp_Email ='" + email + "'; ";
            return (string)dbMan.ExecuteScalar(query);
        }
        public int getCustID(string email)
        {
            string query = "select Customer_ID from Customers,Login_info where Email= Customer_Email and Customer_Email =  '" + email + "'; ";
            return (int)dbMan.ExecuteScalar(query);
        }
        public string getCustname(string email)
        {
            string query = "select Fname from Customers,Login_info where Email= Customer_Email and  Customer_Email ='" + email + "'; ";
            return (string)dbMan.ExecuteScalar(query);
        }




    }
}