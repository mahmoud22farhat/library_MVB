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
    public partial class frm_Borrow : DevExpress.XtraEditors.XtraForm,IBorrow
    {


        public int Row { get => row; set => row = value; }
        public int ID { get => Convert.ToInt32(txt_ID.Text); set => txt_ID.Text = value.ToString(); }
        public int BookID { get => Convert.ToInt32(cbx_books.SelectedValue); set => cbx_books.SelectedValue = value.ToString(); }
        public int borrowID { get => Convert.ToInt32(cbx_borrow.SelectedValue); set => cbx_borrow.SelectedValue = value.ToString(); }
        public string StartDate { get => dtp_startdate.Text; set => dtp_startdate.Text = value; }
        public string EndDate { get => dtp_Enddate.Text; set => dtp_Enddate.Text = value; }
        public string Notes { get => txt_Notes.Text; set => txt_Notes.Text = value; }

        public object cbxBorrowDatasource { get => cbx_borrow.DataSource; set => cbx_borrow.DataSource = value; }
        public string BorrowDisplaymember { get =>cbx_borrow.DisplayMember; set => cbx_borrow.DisplayMember=value; }
        public string Borrowvaluemember { get => cbx_borrow.ValueMember; set => cbx_borrow.ValueMember = value; }
        public int SelectedIndexBorrow { get => cbx_borrow.SelectedIndex; set => cbx_borrow.SelectedIndex=value; }

        public object cbxBookDatasource { get => cbx_books.DataSource; set => cbx_books.DataSource = value; }
        public string BookDisplaymember { get => cbx_books.DisplayMember; set => cbx_books.DisplayMember = value; }
        public string Bookvaluemember { get => cbx_books.ValueMember; set => cbx_books.ValueMember = value; }
        public int SelectedIndexBook { get => cbx_books.SelectedIndex; set => cbx_books.SelectedIndex = value; }

        object IBorrow.btn_add { get => btn_add.Enabled; set => btn_add.Enabled = Convert.ToBoolean(value); }
        object IBorrow.btn_new { get => btn_new.Enabled; set => btn_new.Enabled = Convert.ToBoolean(value); }
        object IBorrow.btn_save { get => btn_save.Enabled; set => btn_save.Enabled = Convert.ToBoolean(value); }
        object IBorrow.btn_delete { get => btn_delete.Enabled; set => btn_delete.Enabled = Convert.ToBoolean(value); }
        object IBorrow.btn_deleteall { get => btn_deleteall.Enabled; set => btn_deleteall.Enabled = Convert.ToBoolean(value); }

        int row = 0;
       BorrowPresenter borpresenter;

        public frm_Borrow()     
        {
            InitializeComponent();
            borpresenter = new BorrowPresenter(this);

        }
        private void frm_Borrow_Load(object sender, EventArgs e)
        {
            borpresenter.fillcbxBooksData();
            borpresenter.fillcbxBorrowData();
            borpresenter.AutoNumber();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            bool check = borpresenter.BorrowInsert();
            if (check)
            {
                MessageBox.Show("تم اضافة العملية ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                borpresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم اضافة العملية ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            frm_Borrow_Load(null, null);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool check = borpresenter.BorrowUpdate();
            if (check)
            {
                MessageBox.Show("تم تعديل العملية ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                borpresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم تعديل العملية ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool check = borpresenter.BorrowDelete();
            if (check)
            {
                MessageBox.Show("تم حذف العملية ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                borpresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم حذف العملية ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deleteall_Click(object sender, EventArgs e)
        {
            bool check = borpresenter.BorrowDeleteAll();
            if (check)
            {
                MessageBox.Show("تم حذف الكل ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                borpresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم حذف الكل ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            row = 0;
            borpresenter.getrow(row);
        }

        private void btn_priv_Click(object sender, EventArgs e)
        {
            try
            {
                int countrow = Convert.ToInt32(borpresenter.Getlastrow().Rows[0][0]) - 1;
                if (row == 0)
                {
                    row = countrow;
                }
                else
                {
                    row = row - 1;

                }

                borpresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                int countrow = Convert.ToInt32(borpresenter.Getlastrow().Rows[0][0]);
                if (countrow == row)
                {
                    row = 0;
                }
                else
                {
                    row = row + 1;

                }

                borpresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            try
            {
                int countlastrow = Convert.ToInt32(borpresenter.Getlastrow().Rows[0][0]) - 1;
                row = countlastrow;

                borpresenter.getrow(row);
            }
            catch (Exception) { }
        }
    }
}