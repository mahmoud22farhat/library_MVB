using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVB.logic.services
{
   static class BorrowerService
    {

        //this method to add insert parameter into stored procedure
        public static bool Borrowerinsert(int id, string name, string phone, string address, string note)
        {

            return DBHelper.excutdata("BorrowerInsert", () => Borrowparmaterinsert(id,  name,  phone,  address, note,DBHelper.command));

        }
        
        private static void Borrowparmaterinsert(int id, string name, string phone, string address, string note, SqlCommand command)
        {

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@note", SqlDbType.NVarChar).Value = note;
        }
        //this method to update parameter into stored procedure
        public static bool Borrowerupdate(int id, string name, string phone, string address, string note)
        {

            return DBHelper.excutdata("BorrowerUpdate", () => Borrowparmaterupdate(id, name, phone, address, note, DBHelper.command));

        }

        private static void Borrowparmaterupdate(int id, string name, string phone, string address, string note, SqlCommand command)
        {

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@note", SqlDbType.NVarChar).Value = note;
        }
        //this method to delete parameter into stored procedure
        public static bool borrowdelete(int id)
        {

            return DBHelper.excutdata("borrowerDelete", () => borrowparmaterdelete(id, DBHelper.command));

        }
        private static void borrowparmaterdelete(int id, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;

        }

        //this method to delete all parameter into stored procedure
        public static bool borrowdeleteall()
        {

            return DBHelper.excutdata("borrowerDeleteall", () => borrowparmaterdeleteall());

        }
        private static void borrowparmaterdeleteall()
        {


        }
        public static DataTable getBorrowersmaxid()
        {

            return DBHelper.getData("BorrowersMaxID", () => { });
        }

        //this method to get last Row show in DGV
        public static DataTable getlastrow()
        {
            return DBHelper.getData("BorrowersgetlastRow", () => { });

        }
        public static DataTable getallBorrowersdatacountryid()
        {

            return DBHelper.getData("BorrowersGetallcountryID", () => { });
        }
    }
}
