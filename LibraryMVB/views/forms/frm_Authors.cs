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
using LibraryMVB.views.Interfaace;
using LibraryMVB.logic.presenter;

namespace LibraryMVB.views.forms
{
    public partial class frm_Authors : DevExpress.XtraEditors.XtraForm ,IAuthors
    {

        public int ID { get =>Convert.ToInt32( txt_ID.Text); set => txt_ID.Text=value.ToString(); }
        public string Authorname { get => txt_Name.Text; set => txt_Name.Text=value; }
        public string AuthorDate { get => dtp_date.Text; set => dtp_date.Text=value; }
        public int CountryID { get => Convert.ToInt32(cbx_country.SelectedValue); set => cbx_country.SelectedValue=value; }
        public object dataGridView { get =>Dgv_search.DataSource; set => Dgv_search.DataSource=value; }
        public object cbxcountry { get => cbx_country.DataSource; set => cbx_country.DataSource=value; }
        object IAuthors.btn_add { get => btn_add.Enabled; set => btn_add.Enabled = Convert.ToBoolean(value); }
        object IAuthors.btn_new { get => btn_new.Enabled; set => btn_new.Enabled = Convert.ToBoolean(value); }
        object IAuthors.btn_save { get => btn_save.Enabled; set => btn_save.Enabled = Convert.ToBoolean(value); }
        object IAuthors.btn_delete { get => btn_delete.Enabled; set => btn_delete.Enabled = Convert.ToBoolean(value); }
        object IAuthors.btn_deleteall { get => btn_deleteall.Enabled; set => btn_deleteall.Enabled = Convert.ToBoolean(value); }
        public string AuthorDisplaymember { get => cbx_country.DisplayMember; set => cbx_country.DisplayMember=value; }
        public string Authorvaluemember { get => cbx_country.ValueMember; set => cbx_country.ValueMember=value; }
        public int SelectedIndex { get =>cbx_country.SelectedIndex ; set =>cbx_country.SelectedIndex=value ; }
        public int Selectedvalue { get => Convert.ToInt32(cbx_country.SelectedValue); set => cbx_country.SelectedValue=value; }
        public int Row { get =>row; set => row=value; }

        public int row;
        AuthorsPresenter authorsPresenter;

        public frm_Authors()
                {
                    InitializeComponent();
            authorsPresenter = new AuthorsPresenter(this);
                }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم التصنيف", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            bool check = authorsPresenter.AuthorsInsert();
            if (check)
            {
                MessageBox.Show("تم اضافة التصنيف ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                authorsPresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم اضافة التصنيف ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_Authors_Load(object sender, EventArgs e)
        {
           
                authorsPresenter.fillcbx();
                authorsPresenter.AutoNumber();
                
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            row = 0;
            authorsPresenter.getrow(row);
        }

        private void btn_priv_Click(object sender, EventArgs e)
        {
            try
            {
                int countrow = Convert.ToInt32(authorsPresenter.Getlastrow().Rows[0][0]) - 1;
                if (row == 0)
                {
                    row = countrow;
                }
                else
                {
                    row = row - 1;

                }

                authorsPresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                int countrow = Convert.ToInt32(authorsPresenter.Getlastrow().Rows[0][0]);
                if (countrow == row)
                {
                    row = 0;
                }
                else
                {
                    row = row + 1;

                }

                    authorsPresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            try
            {
                int countlastrow = Convert.ToInt32(authorsPresenter.Getlastrow().Rows[0][0]) - 1;
                row = countlastrow;

                authorsPresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            frm_Authors_Load(null, null);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم التصنيف", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            bool check = authorsPresenter.AuthorsUpdate();
            if (check)
            {
                MessageBox.Show("تم تعديل التصنيف ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                authorsPresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم تعديل التصنيف ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool check = authorsPresenter.DeleteAuthor();
            if (check)
            {
                MessageBox.Show("تم حذف المؤلف", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لم يتم حذف المؤلف ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deleteall_Click(object sender, EventArgs e)
        {
            bool check = authorsPresenter.DeleteallAuthor();
            if (check)
            {
                MessageBox.Show("تم حذف الكل", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لم يتم حذف الكل ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}