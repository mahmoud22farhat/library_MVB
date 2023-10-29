using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVB.logic.services
{
   static class CategoryServices
    {  //this method to add insert parameter into stored procedure
        public static bool categoryinsert(int id, string name)
        {
            
             return   DBHelper.excutdata("categoryInsert", () => categoryparmaterinsert(id, name, DBHelper.command));
         
        }     
        private static void categoryparmaterinsert(int id ,string name,SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commmand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }


        //this method to delete parameter into stored procedure
        public static bool categorydelete(int id)
        {

           return   DBHelper.excutdata("categoryDelete", () => categoryparmaterdelete(id, DBHelper.command));
           
        }      
        private static void categoryparmaterdelete(int id, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
         
        }

        //this method to delete all parameter into stored procedure
        public static bool categorydeleteall()
        {

            return DBHelper.excutdata("categoryDeleteAll", () => categoryparmaterdeleteall());

        }
        private static void categoryparmaterdeleteall()
        {
           

        }


        //this method to add update parameter into stored procedure
        public static bool categoryupdate(int id, string name)
        {

           return  DBHelper.excutdata("categoryUpdate", () => categoryparmaterupdate(id, name, DBHelper.command));
           
        }
        private static void categoryparmaterupdate(int id, string name, SqlCommand commmand)
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
            return DBHelper.getData("categorygetall", () => { });


        }
        //this method to get last Row show in DGV
        public static DataTable getlastrow()
        {
            return DBHelper.getData("categorygetlastRow", () => { });

        }
        //this method to get Max ID in table
        public static DataTable getMaxID()
        {
            return DBHelper.getData("categoryMaxID", () => { });

        }
    }
}
