using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Bookstore_Application
{
    class EmController
    {
        DBManager dbMan;

        public EmController()
        {
            dbMan = new DBManager();
        }


        public int CountBooks()
        {
            string query = "select Count(*) from Books ";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int CountEmployees()
        {
            string query = "select Count(*) from Employees ";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int CountAuther()
        {
            string query = "select Count(*) from Authors ";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int GetAuthorID(string fname,string lname)
        {
            string qurey = "select Author_ID from Authors where Fname = '" + fname +"' and LastName = '"+ lname + "'";
            return  Convert.ToInt32(dbMan.ExecuteScalar(qurey));
        }
        public int CountBranches()
        {
            string query = "select Count(*) from Branches";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int InsertBook(int Book_ID, string BookName, string Book_Language, string Genre, int Price, int Quantity, string Book_Description, int Rating, int Author_ID, int Publisher_ID)
        {
            string StoredProcedureName = "AddBooks";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Book_ID", Book_ID);
            Parameters.Add("@BookName", BookName);
            Parameters.Add("@Book_Language", Book_Language);
            Parameters.Add("@Genre", Genre);
            Parameters.Add("@Price", Price);
            Parameters.Add("@Quantity", Quantity);
            Parameters.Add("@Book_Description", Book_Description);
            Parameters.Add("@Rating", Rating);
            Parameters.Add("@Author_ID", Author_ID);
            Parameters.Add("@Publisher_ID", Publisher_ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int EditBookPrice(int Book_ID, int Price)
        {
            string StoredProcedureName = "Edit_Price_Books";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Book_ID", Book_ID);
            Parameters.Add("@Price", Price);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int EditQuantityPrice(int Book_ID, int Quantity)
        {
            string StoredProcedureName = "Edit_Quantity_Books";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Book_ID", Book_ID);
            Parameters.Add("@Quantity", Quantity);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable ViewAllRequests()
        {
            string StoredProcedureName = "View_Pending_Request";
            return dbMan.ExecuteReader(StoredProcedureName);
        }
        public DataTable ViewAllPurchaseHistory()
        {
            string StoredProcedureName = "View_Purchase_History";
            return dbMan.ExecuteReader(StoredProcedureName);
        }
        public int DeleteBook(int Book_ID)
        {
            string StoredProcedureName = "Delete_Book";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Book_ID", Book_ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertEmployee(int Emp_ID, string Fname, string MidName, string LastName, string Emp_Address, string Gender, int Salary, int Branch_ID, int Manager_ID, string Emp_Email)
        {
            string StoredProcedureName = "AddEmployee";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Emp_ID", Emp_ID);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@MidName", MidName);
            Parameters.Add("@LastName", LastName);
            Parameters.Add("@Emp_Address", Emp_Address);
            Parameters.Add("@Gender", Gender);
            Parameters.Add("@Salary", Salary);
            Parameters.Add("@Branch_ID", Branch_ID);
            Parameters.Add("@Manager_ID", Manager_ID);
            Parameters.Add("@Emp_Email", Emp_Email);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertUs(string email, string pass, string user)
        {

            string StoredProcedureName = "Insertnewuser";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@UserEmail", email);
            Parameters.Add("@UserPassword", pass);
            Parameters.Add("@Usert", user);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int EditEmpAddress(int Emp_ID, string address)
        {
            string StoredProcedureName = "Edit_Emp_Address";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Emp_ID", Emp_ID);
            Parameters.Add("@Emp_Address", address);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int EditEmpBranchID( int Emp_ID, int Branch_ID)
        {
            string StoredProcedureName = "Edit_Emp_BranchID";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Emp_ID", Emp_ID);
            Parameters.Add("@Branch_ID", Branch_ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int GetBranchIDfromEmpTable(int Emp_ID)
        {
            string query = "Get_Emp_BranchID";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Emp_ID", Emp_ID);
            return Convert.ToInt32(dbMan.ExecuteScalar(query, Parameters));
        }
        public int GetBranchID(int Emp_ID)
        {
            string query = "View_Emp_BranchID";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Manager_ID", Emp_ID);
            return Convert.ToInt32(dbMan.ExecuteScalar(query,Parameters));
        }
        public int GetManagerID(int Branch_ID)
        {
            string query = "View_Emp_ManagerID";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Branch_ID", Branch_ID);
            return (int)dbMan.ExecuteScalar(query, Parameters);
        }

        public int EditEmpManagerID(int Emp_ID, int ManagerID)
        {
            string StoredProcedureName = "Edit_Emp_ManagerID";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Emp_ID", Emp_ID);
            Parameters.Add("@Manager_ID", ManagerID);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int DeleteEmployee(int Emp_ID)
        {
            string StoredProcedureName = "Delete_Employee";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Emp_ID", Emp_ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int DeleteBranch(int BranchID)
        {
            string StoredProcedureName = "Delete_Branche";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Branch_ID", BranchID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int DeleteSale(int SaleID)
        {
            string StoredProcedureName = "Delete_Sale";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Sales_ID", SaleID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int EditBranchName(int BranchID, string Name)
        {
            string StoredProcedureName = "Edit_Name_Branches";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Branch_ID", BranchID);
            Parameters.Add("@BranchName", Name);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int EditBranchManager( int BranchID, int Emp_ID)
        {
            string StoredProcedureName = "Edit_Manager_Branches";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Branch_ID", BranchID);
            Parameters.Add("@Manager_ID", Emp_ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        
        public int EditManagerCascasde(int Emp_ID, int BranchID)
        {
            string StoredProcedureName = "Edit_Emp_ManagerID_Cascade";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Branch_ID", BranchID);
            Parameters.Add("@Manager_ID", Emp_ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }



        public int EditEmpSalary(int Emp_ID, int Salary)
        {
            string StoredProcedureName = "Edit_Emp_Salary";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Emp_ID", Emp_ID);
            Parameters.Add("@Salary", Salary);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        

        public int AddBranch(int Branch_ID, string BranchName, string Branch_Location, int Manager_ID)
        {
            string StoredProcedureName = "Add_Branches";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Branch_ID", Branch_ID);
            Parameters.Add("@BranchName", BranchName);
            Parameters.Add("@Branch_Location", Branch_Location);
            Parameters.Add("@Manager_ID", Manager_ID);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int AddAuthor(int AuthorID, string FirstName, string LastName)
        {
            string StoredProcedureName = "InsertAuthor";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Authorid", AuthorID);
            Parameters.Add("@Authorfname", FirstName);
            Parameters.Add("@Authorlname", LastName);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int UpdateRequestStatues(int Request_ID, string Status)
        {
            string StoredProcedureName = "Process_Pending_Request";
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RequestStatues", Status);
            Parameters.Add("@Request_ID", Request_ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        /// CustController 
        /// 
        public int AddSaleToHistory(string Sale_ID, string SalePrice, string CustomerID,string Branch,string EmpID)
        {
            string query = "Insert Into Sales_History Values(" + Sale_ID + " , " + SalePrice + ","+ Branch +"," + EmpID +"," + CustomerID + " )";

            return dbMan.ExecuteNonQuery(query);
        }
        public int FillSoldBooks(string SaleID, string BookID, string Quantity = "1")
        {

            string query = "INSERT INTO SoldBooks Values(" + SaleID + " , " + BookID + " , " + Quantity + " );";
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

            return Convert.ToInt32(dbMan.ExecuteScalar(StrProc, Parameters));
        }

        public string GetPWFromMail(string Email)
        {
            string StrProc = CustStoredProc.GetPWFromMail;


            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Email", Email);

            return Convert.ToString(dbMan.ExecuteScalar(StrProc, Parameters));

        }

        public int UpdatePassword(string Email, string Password)
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

        public int AddRating(string cid, string bid, string rating)
        {
            string query = "Insert Into CustomerRating Values( " + cid + " , " + bid + " , " + rating + " ) ;";

            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateRating(string cid, string bid, string rating)
        {
            string query = "Update CustomerRating Set Rating = " + rating + " where CustomerID = " + cid + " AND Book_ID = " + bid + " ;";


            return dbMan.ExecuteNonQuery(query);
        }


        public int CheckIfPreviouslyRated(string CusID, string BID)
        {
            string query = "Select Count(*) from CustomerRating where CustomerID = " + CusID + " AND Book_ID = " + BID + " ;";

            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public DataTable GetSearchedBook(object BookName, object Genre, object Author, object Language, object Publisher)
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


        public void TerminateConnection()
            {
                dbMan.CloseConnection();
            }
        }
    }

