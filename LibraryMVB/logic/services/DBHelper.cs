using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace LibraryMVB.logic.services
{
    public class DBHelper
    {
        //دالة الاتصال الرئيسية
        public static SqlCommand command;
        static private SqlConnection getconnictionstring()

        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = Properties.Settings.Default.servername;
            builder.InitialCatalog = Properties.Settings.Default.DBName;
            builder.IntegratedSecurity = true;

            return new SqlConnection(builder.ConnectionString);

        } 
        public static bool excutdata(string spName)
        {

            using (SqlConnection Connection = getconnictionstring())
            {
                try
                {
                    command = new SqlCommand(spName, Connection);
                    command.CommandType = CommandType.StoredProcedure;

                    Connection.Open();
                    command.ExecuteNonQuery();
                    Connection.Close();
                    return true;
                }
                catch (Exception ex) {

                    Connection.Close();
                    Console.WriteLine(ex.Message);
                    return false;
                }
                finally
                {
                    Connection.Close();
                }
            }


                return false;
        }
    }
}
