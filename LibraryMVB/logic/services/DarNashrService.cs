using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVB.logic.services
{
   static class DarNashrService
    {
        //this method to add into dar table in DB

        public static bool darinsert(int id, string name, int countryid)
        {

            return DBHelper.excutdata("DarNashrInsert", () => darparmaterinsert(id, name, countryid, DBHelper.command));

        }

     
        //this method to add insert parameter into stored procedure
        private static void darparmaterinsert(int id, string name, int countryid, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commmand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            commmand.Parameters.Add("@countryID", SqlDbType.Int).Value = countryid;

        }

        //this method to update into dar table in DB
        public static bool darUpdate(int id, string name, int countryid)
        {

            return DBHelper.excutdata("DarNashrUpdate", () => darparmaterUpdate(id, name, countryid, DBHelper.command));

        }
        //this method to add update parameter into stored procedure
        private static void darparmaterUpdate(int id, string name, int countryid, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commmand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            commmand.Parameters.Add("@countryID", SqlDbType.Int).Value = countryid;

        }  //this method to delete parameter into stored procedure
        public static bool dardelete(int id)
        {

            return DBHelper.excutdata("DarNashrDelete", () => darparmaterdelete(id, DBHelper.command));

        }
        private static void darparmaterdelete(int id, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;

        }
        //this method to delete all parameter into stored procedure
        public static bool dardeleteall()
        {

            return DBHelper.excutdata("DarNashrDeleteall", () => darparmaterdeleteall());

        }
        private static void darparmaterdeleteall()
        {
            
        }
        //this method to get all data to show in cbx
        public static DataTable getalldatacountry()
        {
            return DBHelper.getData("countrygetall", () => { });
        }
        //this method to get all data to show in DGV
        public static DataTable getalldardata()
        {
            return DBHelper.getData("darnashrgetall", () => { });
        }
        public static DataTable getalldardataByid()
        {
            return DBHelper.getData("darnashrgetallID", () => { });
        }
        //this method to get getmaxid to show in txt id
        public static DataTable getdarNashrmaxid()
        {
            return DBHelper.getData("DarNashrMaxID", () => { });
        }
        //this method to get last Row show in DGV
        public static DataTable getlastrow()
        {
            return DBHelper.getData("DarNashrgetlastRow", () => { });
        }
    }
}
