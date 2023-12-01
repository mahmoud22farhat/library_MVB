using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVB.logic.services
{
    class BorrowServices
    {
        public static DataTable getallBooksborrowdata()
        {
            return DBHelper.getData("Booksborrowgetall", () => { });
        }
        public static DataTable getmaxid()
        {
            return DBHelper.getData("BorrowgetMaxID", () => { });
        }
        
        public static DataTable getallBorrowdatacountryid()
        {
            return DBHelper.getData("BorrowGetallcountryID", () => { });
        }
        //this method to add into book borrow table in DB

        public static bool Borrowinsert(int id, int bookID, int borrowID, string startdate,string enddate,string notes)
        {

            return DBHelper.excutdata("BorrowInsert", () => Borrowparmaterinsert( id,  bookID,  borrowID,  startdate,  enddate,  notes, DBHelper.command));

        }
        //this method to add insert parameter into stored procedure
        private static void Borrowparmaterinsert(int id, int bookID, int borrowID, string startdate, string enddate, string notes, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commmand.Parameters.Add("@Book_ID", SqlDbType.Int).Value = bookID;
            commmand.Parameters.Add("@Borrow_ID", SqlDbType.Int).Value = borrowID;

            commmand.Parameters.Add("@Start_Date", SqlDbType.NVarChar).Value = startdate;
            commmand.Parameters.Add("@End_Date", SqlDbType.NVarChar).Value = enddate;

            commmand.Parameters.Add("@note", SqlDbType.NVarChar).Value = notes;

        }
        //this method to update into book borrow table in DB

        public static bool Borrowupdate(int id, int bookID, int borrowID, string startdate, string enddate, string notes)
        {

            return DBHelper.excutdata("Borrowupdate", () => Borrowparmaterupdate(id, bookID, borrowID, startdate, enddate, notes, DBHelper.command));

        }
        //this method to  update parameter into stored procedure
        private static void Borrowparmaterupdate(int id, int bookID, int borrowID, string startdate, string enddate, string notes, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commmand.Parameters.Add("@Book_ID", SqlDbType.Int).Value = bookID;
            commmand.Parameters.Add("@Borrow_ID", SqlDbType.Int).Value = borrowID;

            commmand.Parameters.Add("@Start_Date", SqlDbType.NVarChar).Value = startdate;
            commmand.Parameters.Add("@End_Date", SqlDbType.NVarChar).Value = enddate;

            commmand.Parameters.Add("@note", SqlDbType.NVarChar).Value = notes; 

        }

        public static bool Borrowdelete(int id)
        {

            return DBHelper.excutdata("BorrowDelete", () => Borrowparmaterdelete(id, DBHelper.command));

        }
        private static void Borrowparmaterdelete(int id, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
         

        }
        public static bool Borrowdeleteall()
        {

            return DBHelper.excutdata("BorrowDeleteall", () => Borrowparmaterdeleteall());

        }
        private static void Borrowparmaterdeleteall( )
        {


        }
    }
}
