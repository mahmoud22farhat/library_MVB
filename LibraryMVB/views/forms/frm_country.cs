using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LibraryMVB.logic.presenter;
using LibraryMVB.views.Interfaace;

namespace LibraryMVB.views.forms
{
    public partial class frm_country : DevExpress.XtraEditors.XtraForm , Icountry
    {

        public int ID { get => Convert.ToInt32(txt_ID.Text); set => txt_ID.Text = value.ToString(); }
        public string Countryname { get => Convert.ToString(txt_Name.Text); set => txt_Name.Text = value.ToString(); }
        public object dataGridView { get =>Dgv_search.DataSource ; set => Dgv_search.DataSource=value; }
        int Icountry.row { get => row; set => row=value; }
        object Icountry.btn_add { get => btn_add.Enabled; set => btn_add.Enabled=Convert.ToBoolean(value); }
        object Icountry.btn_new { get => btn_new.Enabled; set => btn_new.Enabled = Convert.ToBoolean(value); }
        object Icountry.btn_save { get => btn_save.Enabled; set => btn_save.Enabled = Convert.ToBoolean(value); }
        object Icountry.btn_delete { get => btn_delete.Enabled; set => btn_delete.Enabled = Convert.ToBoolean(value); }
        object Icountry.btn_deleteall { get => btn_deleteall.Enabled; set => btn_deleteall.Enabled = Convert.ToBoolean(value); }

        int row = 0;
        countrypresenter countrypresenter;
        public frm_country()
        {
            InitializeComponent();
            countrypresenter = new countrypresenter(this);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الدولة","تأكيد",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            bool check =countrypresenter.CountryInsert();
            if (check)
            {
                MessageBox.Show("تم اضافة الدولة ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم اضافة الدولة ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool check = countrypresenter.countryDelete();
            if (check)
            {
                MessageBox.Show("تم حذف الدولة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لم يتم حذف الدولة ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool check = countrypresenter.countryUpdate();
            if (check)
            {
                MessageBox.Show("تم التعديل", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لم يتم التعديل ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            countrypresenter.clearfiledes();

            countrypresenter.AutoNumber();
        }

        private void btn_deleteall_Click(object sender, EventArgs e)
        {
            bool check = countrypresenter.countryDeleteall();
            if (check)
            {
                MessageBox.Show("تم الحذف", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لم يتم الحذف ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_country_Load(object sender, EventArgs e)
        {
            countrypresenter.getalldata();
            countrypresenter.AutoNumber();

        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            try
            {
                row = 0;
                countrypresenter.getrow(row);
            }
            catch (Exception) { }
            }

        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                int countrow = Convert.ToInt32(countrypresenter.Getlastrow().Rows[0][0]);
                if (countrow == row)
                {
                    row = 0;
                }
                else
                {
                    row = row + 1;

                }
             
                countrypresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_priv_Click(object sender, EventArgs e)
        {
            try
            {
                int countrow = Convert.ToInt32(countrypresenter.Getlastrow().Rows[0][0])-1;
                if (row == 0)
                {
                    row = countrow;
                }
                else
                {
                    row = row - 1;

                }
               
                countrypresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {

            try
            {
                int countlastrow=Convert.ToInt32(countrypresenter.Getlastrow().Rows[0][0])-1;
            row = countlastrow;
       
            countrypresenter.getrow(row);
        }
            catch (Exception) { }
}
    }
}