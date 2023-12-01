using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVB.logic.services
{
    class BooksSearchServices
    {
        public static DataTable getallBooks()
        {            
            return DBHelper.getData("BooksGetAll", () => { });            
        }



        public static DataTable getallBooksByid(int id)
        {
            return DBHelper.getData("BooksGetAllByid", () => BooksSearchID(id, DBHelper.command));
        }

      
        private static void BooksSearchID(int id, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
          
        }

        public static DataTable getallBooksBycat(int catid)
        {
            return DBHelper.getData("BooksGetAllByCat", () => BooksSearchcat(catid, DBHelper.command));
        }


        private static void BooksSearchcat(int catid, SqlCommand commmand)
        {
            commmand.Parameters.Add("@catid", SqlDbType.Int).Value = catid;

        }
    }
}
