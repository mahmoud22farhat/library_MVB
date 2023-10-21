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
       
        public static SqlCommand command;
        //دالة الاتصال الرئيسية
        static private SqlConnection getconnictionstring()

        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = Properties.Settings.Default.servername;
            builder.InitialCatalog = Properties.Settings.Default.DBName;
            builder.IntegratedSecurity = true;

            return new SqlConnection(builder.ConnectionString);

        } 
       
        //هذه الدالة لعمل للاضافةوالتعديل والتحديث والمسح ومسح الجميع من قاعدة البيانات
        public static bool excutdata(string spName,Action method)
        {
 //اسم دالة الاكشن هي ميثود
        //الاكشن هي البراميتر التي تحمل الداله التي بداخلها الدوال
            using (SqlConnection Connection = getconnictionstring())
            {
                try
                {
                    command = new SqlCommand(spName, Connection);
                    command.CommandType = CommandType.StoredProcedure;

                    //لادخال البراميترالتي يحتوي علي الدوال
                    method.Invoke();

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
