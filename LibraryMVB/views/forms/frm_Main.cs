using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using LibraryMVB.logic.services;
using static LibraryMVB.logic.services.DBHelper;
using Microsoft.SqlServer.Management.Smo;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
using Microsoft.SqlServer.Management.Common;

namespace LibraryMVB.views.forms
{
    public partial class frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
       Thread t;
        public frm_Main()
        {
           
        InitializeComponent();
            try
            {
                t = new Thread(new ThreadStart(startsplash));
                t.Start();
                Thread.Sleep(5000);
                t.Abort();
            }
            catch (Exception) { }

        }

        private void startsplash()
        {
            try
            {
                Application.Run(new splash_screen());

            }
            catch (Exception) { }
        }


        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_category frm = new frm_category();
            frm.ShowDialog();
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_Authors frm = new frm_Authors();
            frm.ShowDialog();
        }
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_Bookplaces frm = new frm_Bookplaces();
            frm.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_dar_elNasher frm = new frm_dar_elNasher();
            frm.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_country frm = new frm_country();
            frm.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_BooksData frm = new frm_BooksData();
            frm.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_BooksSearch frm = new frm_BooksSearch();
            frm.ShowDialog();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_Borroewars frm = new frm_Borroewars();
            frm.ShowDialog();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_Borrow frm = new frm_Borrow();
            frm.ShowDialog();
        }
        database db = new database();
        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {


            try
            {
                string d = DateTime.Now.Date.ToString("yyyy-MM-dd");
                SaveFileDialog open = new SaveFileDialog();
                open.Filter = "Back Files (*.back) | *.back";
                open.FileName = "Library_BackUp_" + d;


                if (open.ShowDialog() == DialogResult.OK)
                {

                    db.excetedate("backup database LibraryMVB TO disk = '" + open.FileName + "'", "");

                    MessageBox.Show("تم اخذ نسخه احتياطيه بنجاح", "");
                }

            }
            catch (Exception) { }

        }
        private void tileItem13_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frm_BooksSearch frm = new frm_BooksSearch();
            frm.ShowDialog();
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frm_category frm = new frm_category();
            frm.ShowDialog();
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frm_Authors frm = new frm_Authors();
            frm.ShowDialog();
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frm_Bookplaces frm = new frm_Bookplaces();
            frm.ShowDialog();
        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frm_dar_elNasher frm = new frm_dar_elNasher();
            frm.ShowDialog();
        }

        private void tileItem5_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frm_country frm = new frm_country();
            frm.ShowDialog();
        }

        private void tileItem12_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frm_BooksData frm = new frm_BooksData();
            frm.ShowDialog();
        }

        private void tileItem8_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frm_Borroewars frm = new frm_Borroewars();
            frm.ShowDialog();
        }

        private void tileItem9_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frm_Borrow frm = new frm_Borrow();
            frm.ShowDialog();
        }
        private bool sheckdatabase()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NJ3N9G2;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("", conn);
            SqlDataReader rdr;
            try
            {
                cmd.CommandText = "exec sys.sp_databases";
                conn.Open();

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr.GetString(0) == " LibraryMVB")
                    {
                        return true;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            conn.Close();
            rdr.Dispose();
            cmd.Dispose();
            return false;
        }
        private void createdatabase()
        {


            bool check = sheckdatabase();
            if (check == false)
            {
                try
                {
                    //string conn = @"Data Source=DESKTOP-NJ3N9G2;Integrated Security=True";
                    //string script = File.ReadAllText(Application.StartupPath + @"\script.sql");
                    //SqlConnection co = new SqlConnection(conn);
                    //Server server = new Server(new ServerConnection(co));

                    //server.ConnectionContext.ExecuteNonQuery(script);


                    var filecontent = File.ReadAllText(Application.StartupPath + @"\script.sql");
                    var sqlqueries = filecontent.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);
                    var con = new SqlConnection(@"Data Source=DESKTOP-NJ3N9G2;Integrated Security=True");
                    var cmd = new SqlCommand("quary", con);
                    con.Open();
                    foreach (var quary in sqlqueries)
                    {
                        cmd.CommandText = quary;
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        private void frm_Main_Load(object sender, EventArgs e)
        {
            try
            {
                createdatabase();
                
            }
            catch (Exception) { }
            barButtonItem14.Caption = "التاريخ |" + DateTime.Now.ToShortDateString();
          
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            Server server = new Server(@"DESKTOP-NJ3N9G2");
            Microsoft.SqlServer.Management.Smo.Database db = server.Databases["LibraryMVB"];

            //لقفل اي عمليه موجوده علي قاعدة البيانات
            if (db != null)
            {
                server.KillAllProcesses(db.Name);

            }
            //لأخذ النسخه ووضعها في قاعدة البيانات مباشرة
            Restore restore = new Restore();


            restore.Database = db.Name;
            restore.Action = RestoreActionType.Database;

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Backup Files (*.back)|*.back|All Files (*.*)|*.*";
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
                restore.Devices.AddDevice(open.FileName, DeviceType.File);
                restore.ReplaceDatabase = true;
                restore.NoRecovery = false;
                restore.SqlRestore(server);
                MessageBox.Show("تم استرجاع النسخه الاحتياطيه بنجاح", "تاكيد");
            }
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        
    } }
    
