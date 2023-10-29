using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVB.logic.services
{
   static class countryservice
    {
        //this method to add insert parameter into stored procedure
        public static bool countryinsert(int id, string name)
        {

            return DBHelper.excutdata("countryInsert", () => countryparmaterinsert(id, name, DBHelper.command));

        }
        private static void countryparmaterinsert(int id, string name, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commmand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }


        //this method to delete parameter into stored procedure
        public static bool countrydelete(int id)
        {

            return DBHelper.excutdata("countryDelete", () => countryparmaterdelete(id, DBHelper.command));

        }
        private static void countryparmaterdelete(int id, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;

        }

        //this method to delete all parameter into stored procedure
        public static bool countrydeleteall()
        {

            return DBHelper.excutdata("countryDeleteAll", () => countryparmaterdeleteall());

        }
        private static void countryparmaterdeleteall()
        {


        }


        //this method to add update parameter into stored procedure
        public static bool countryupdate(int id, string name)
        {

            return DBHelper.excutdata("countryUpdate", () => countryparmaterupdate(id, name, DBHelper.command));

        }
        private static void countryparmaterupdate(int id, string name, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commmand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }




        //this method to get all data to show in DGV
        public static DataTable getalldata()
        {
            /* DataTable tbl = new DataTable();
            tbl= DBHelper.getData("countrygetall", () => { });
             return tbl;*/
             //هذا اختصار للدالة السابقة
            return DBHelper.getData("countrygetall", () => { });


        }
        //this method to get last Row show in DGV
        public static DataTable getlastrow()
        {
            return DBHelper.getData("countrygetlastRow", () => { });

        }
        //this method to get Max ID in table
        public static DataTable getMaxID()
        {
            return DBHelper.getData("countryMaxID", () => { });

        }

    }
}
