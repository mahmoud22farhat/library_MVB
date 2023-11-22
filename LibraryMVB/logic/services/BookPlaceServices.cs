using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVB.logic.services
{
    static class BookPlaceServices
    {
        //this method to add insert parameter into stored procedure
        public static bool bookpalceinsert(int id, string name)
        {

            return DBHelper.excutdata("BookPlaceInsert", () => BookPlaceparmaterinsert(id, name, DBHelper.command));

        }
        
        private static void BookPlaceparmaterinsert(int id, string name, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commmand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }

        //this method to update parameter into stored procedure
        public static bool bookpalceupdate(int id, string name)
        {

            return DBHelper.excutdata("BookPlaceUpdate", () => BookPlaceparmaterupdate(id, name, DBHelper.command));

        }

        private static void BookPlaceparmaterupdate(int id, string name, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commmand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }




        ////this method to delete parameter into stored procedure
        public static bool bookpalcedelete(int id)
        {

            return DBHelper.excutdata("BookPlaceDelete", () => BookPlaceparmaterdelete(id, DBHelper.command));

        }

        private static void BookPlaceparmaterdelete(int id, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
           
        }

        //this method to delete all parameter into stored procedure
        public static bool bookplacedeleteall()
        {

            return DBHelper.excutdata("BookPlaceDeleteAll", () => { });

        }
        private static void bookplaceparmaterdeleteall()
        {


        }
        public static DataTable getalldata()
        {
           
            return DBHelper.getData("BookPlacegetall", () => { });


        }
        //this method to get Max ID in table
        public static DataTable getMaxID()
        {
            return DBHelper.getData("BookBlaceMaxID", () => { });

        }
        //this method to get last Row show in DGV
        public static DataTable getlastrow()
        {
            return DBHelper.getData("bookplacegetlastRow", () => { });

        }
    }
}
