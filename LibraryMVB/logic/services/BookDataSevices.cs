using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryMVB.modles;

namespace LibraryMVB.logic.services
{
    class BookDataSevices
    {//this method to add into Book data table in DB

        public static bool Bookdatainsert(int id, string Book_name, int Cat_ID, int Author_ID, int countryid, int Dar_ID, string supcat, string date, int PagesNumber, int Place_ID, string Book_Status, decimal Book_prices, string Notes)
        {

            return DBHelper.excutdata("BookdataInsert", () => Bookdataparmaterinsert(id, Book_name, Cat_ID, Author_ID, countryid, Dar_ID, supcat, date, PagesNumber, Place_ID, Book_Status, Book_prices, Notes, DBHelper.command));

        }
        //this method to add insert parameter into stored procedure
        private static void Bookdataparmaterinsert(int id, string Book_name, int Cat_ID, int Author_ID, int countryid, int Dar_ID, string supcat, string date, int PagesNumber, int Place_ID, string Book_Status, decimal Book_prices, string Notes, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commmand.Parameters.Add("@Book_name", SqlDbType.NVarChar).Value = Book_name;
            commmand.Parameters.Add("@Cat_id", SqlDbType.Int).Value = Cat_ID;
            commmand.Parameters.Add("@Author_ID", SqlDbType.Int).Value = Author_ID;
            commmand.Parameters.Add("@countryid", SqlDbType.Int).Value = countryid;
            commmand.Parameters.Add("@Dar_ID", SqlDbType.Int).Value = Dar_ID;
            commmand.Parameters.Add("@supcat", SqlDbType.NVarChar).Value = supcat;
            commmand.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;
            commmand.Parameters.Add("@PagesNumber", SqlDbType.Int).Value = PagesNumber;
            commmand.Parameters.Add("@Place_ID", SqlDbType.Int).Value = Place_ID;
            commmand.Parameters.Add("@Book_Status", SqlDbType.NVarChar).Value = Book_Status;
            commmand.Parameters.Add("@Book_prices", SqlDbType.Real).Value = Book_prices;
            commmand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = Notes;

        }


        //this method to add update Book data table in DB

        public static bool BookdataUpdate(int id, string Book_name, int Cat_ID, int Author_ID, int countryid, int Dar_ID, string supcat, string date, int PagesNumber, int Place_ID, string Book_Status, decimal Book_prices, string Notes)
        {

            return DBHelper.excutdata("BookdataUpdata", () => Bookdataparmaterupdate(id, Book_name, Cat_ID, Author_ID, countryid, Dar_ID, supcat, date, PagesNumber, Place_ID, Book_Status, Book_prices, Notes, DBHelper.command));

        }
        //this method to add update parameter into stored procedure
        private static void Bookdataparmaterupdate(int id, string Book_name, int Cat_ID, int Author_ID, int countryid, int Dar_ID, string supcat, string date, int PagesNumber, int Place_ID, string Book_Status, decimal Book_prices, string Notes, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commmand.Parameters.Add("@Book_name", SqlDbType.NVarChar).Value = Book_name;
            commmand.Parameters.Add("@Cat_id", SqlDbType.Int).Value = Cat_ID;
            commmand.Parameters.Add("@Author_ID", SqlDbType.Int).Value = Author_ID;
            commmand.Parameters.Add("@countryid", SqlDbType.Int).Value = countryid;
            commmand.Parameters.Add("@Dar_ID", SqlDbType.Int).Value = Dar_ID;
            commmand.Parameters.Add("@supcat", SqlDbType.NVarChar).Value = supcat;
            commmand.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;
            commmand.Parameters.Add("@PagesNumber", SqlDbType.Int).Value = PagesNumber;
            commmand.Parameters.Add("@Place_ID", SqlDbType.Int).Value = Place_ID;
            commmand.Parameters.Add("@Book_Status", SqlDbType.NVarChar).Value = Book_Status;
            commmand.Parameters.Add("@Book_prices", SqlDbType.Real).Value = Book_prices;
            commmand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = Notes;

        }
        //this method to delete parameter into stored procedure
        public static bool Bookdatadelete(int id)
        {

            return DBHelper.excutdata("BookdataDelete", () => Bookdataparmaterdelete(id, DBHelper.command));

        }
        private static void Bookdataparmaterdelete(int id, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;

        }
        //this method to delete all parameter into stored procedure
        public static bool BookDatadeleteall()
        {

            return DBHelper.excutdata("BookdataDeleteAll", () => BookDataparmaterdeleteall());

        }
        private static void BookDataparmaterdeleteall()
        {


        }
        //this method to get all data to show in cbx
        public static DataTable getallDarNashrdata()
        {           
            return DBHelper.getData("darnashrgetall", () => { });
        }
      
        public static DataTable getallCountrydata()
        {
            return DBHelper.getData("countrygetall", () => { });
        }
        public static DataTable getallCategorydata()
        {
            return DBHelper.getData("categorygetall", () => { });
        }
        public static DataTable getallBookplacedata()
        {
            return DBHelper.getData("BookPlacegetall", () => { });
        }
        public static DataTable getallAuthordata()
        {
            return DBHelper.getData("Authorgetall", () => { });
        }
        public static DataTable getallBooksdata()
        {
            return DBHelper.getData("BooksDatagetall", () => { });
        }
        public static DataTable getallBooks()
        {
            return DBHelper.getData("BooksDatagetall", () => { });
        }



        public static DataTable getBooksMaxID()
        {
            return DBHelper.getData("BooksMaxID", () => { });
        }
        //this method to get last Row show in DGV
        public static DataTable getlastrow()
        {
            return DBHelper.getData("BookDatagetlastRow", () => { });

        }
        public static DataTable getallBookdatacountryid()
        {

            return DBHelper.getData("BookDataGetallcountryID", () => { });
        }
    }
}
