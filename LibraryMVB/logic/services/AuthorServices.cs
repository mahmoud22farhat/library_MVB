using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVB.logic.services
{
    static class AuthorServices
    {
        //this method to add into authors table in DB

        public static bool Authorsinsert(int id, string name, string date, int countryid)
        {

            return DBHelper.excutdata("AuthorsInsert", () => Authorsparmaterinsert(id, name, date, countryid, DBHelper.command));

        }
        //this method to add insert parameter into stored procedure
        private static void Authorsparmaterinsert(int id, string name, string date, int countryid, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commmand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            commmand.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;
            commmand.Parameters.Add("@countryID", SqlDbType.Int).Value = countryid;

        }

        //this method to update into authors table in DB
        public static bool AuthorsUpdate(int id, string name, string date, int countryid)
        {

            return DBHelper.excutdata("AuthorsUpdate", () => AuthorsparmaterUpdate(id, name, date, countryid, DBHelper.command));

        }
        //this method to add update parameter into stored procedure
        private static void AuthorsparmaterUpdate(int id, string name, string date, int countryid, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commmand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            commmand.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;
            commmand.Parameters.Add("@countryID", SqlDbType.Int).Value = countryid;

        }  //this method to delete parameter into stored procedure
        public static bool deleteAuthor(int id)
        {

            return DBHelper.excutdata("AuthorDelete", () => Authorparmaterdelete(id, DBHelper.command));

        }
        private static void Authorparmaterdelete(int id, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;

        }
        //this method to delete all parameter into stored procedure
        public static bool deleteallAuthor()
        {

            return DBHelper.excutdata("AuthorDeleteall", () => Authorparmaterdeleteall());

        }
        private static void Authorparmaterdeleteall()
        {


        }
        //this method to get all data to show in cbx
        public static DataTable getalldata()
        {
            /* DataTable tbl = new DataTable();
            tbl= DBHelper.getData("countrygetall", () => { });
             return tbl;*/
            //هذا اختصار للدالة السابقة
            return DBHelper.getData("countrygetall", () => { });
        }
        //this method to get all data to show in DGV
        public static DataTable getallauthordata()
        {
          
            return DBHelper.getData("Authorgetall", () => { });
        }
        
        public static DataTable getallauthordatacountryid()
        {

            return DBHelper.getData("AuthorGetallcountryID", () => { });
        }

        //this method to get getmaxid to show in txt id
        public static DataTable getauthormaxid()
        {
          
            return DBHelper.getData("AuthorsMaxID", () => { });
        }
       
        //this method to get last Row show in DGV
        public static DataTable getlastrow()
        {
            return DBHelper.getData("AuthorsgetlastRow", () => { });

        }
    }
}
