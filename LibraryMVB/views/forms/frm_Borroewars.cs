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
    public partial class frm_Borroewars : DevExpress.XtraEditors.XtraForm,IBorrowers
    {

        public int ID { get => Convert.ToInt32(txt_ID.Text); set => txt_ID.Text = value.ToString(); }
        public string borname { get => Convert.ToString(txt_Name.Text); set => txt_Name.Text = value.ToString(); }
        public string borphone { get => Convert.ToString(txt_phone.Text); set => txt_phone.Text = value.ToString(); }
        public string boraddres { get => Convert.ToString(txt_address.Text); set => txt_address.Text = value.ToString(); }
        public string bornote { get => Convert.ToString(txt_note.Text); set => txt_note.Text = value.ToString(); }
        object IBorrowers.btn_add { get => btn_add.Enabled; set => btn_add.Enabled = Convert.ToBoolean(value); }
        object IBorrowers.btn_new { get => btn_new.Enabled; set => btn_new.Enabled = Convert.ToBoolean(value); }
        object IBorrowers.btn_save { get => btn_save.Enabled; set => btn_save.Enabled = Convert.ToBoolean(value); }
        object IBorrowers.btn_delete { get => btn_delete.Enabled; set => btn_delete.Enabled = Convert.ToBoolean(value); }
        object IBorrowers.btn_deleteall { get => btn_deleteall.Enabled; set => btn_deleteall.Enabled = Convert.ToBoolean(value); }
        int IBorrowers.row { get => row; set => row=value; }

        int row = 0;
        BorrowersPresenter borPresenter;
        public frm_Borroewars()
        {
            InitializeComponent();
            borPresenter = new BorrowersPresenter(this);

        }
        private void frm_Borroewars_Load(object sender, EventArgs e)
        {
            borPresenter.AutoNumber();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المستعير", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (txt_phone.Text == "")
            {
                MessageBox.Show("من فضلك ادخل هاتف المستعير", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (txt_address.Text == "")
            {
                MessageBox.Show("من فضلك ادخل عنوان المستعير", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            bool check = borPresenter.BorrowersInsert();
            if (check)
            {
                MessageBox.Show("تم اضافة بيانات المستعير ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                borPresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم بيانات المستعير ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المستعير", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (txt_phone.Text == "")
            {
                MessageBox.Show("من فضلك ادخل هاتف المستعير", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (txt_address.Text == "")
            {
                MessageBox.Show("من فضلك ادخل عنوان المستعير", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            bool check = borPresenter.BorrowerUpdate();
            if (check)
            {
                MessageBox.Show("تم تعديل بيانات المستعير ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                borPresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم تعديل بيانات المستعير ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool check = borPresenter.Borrowerdelete();
            if (check)
            {
                MessageBox.Show("تم حذف المستعير", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لم يتم حذف المستعير ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deleteall_Click(object sender, EventArgs e)
        {
            bool check = borPresenter.Borrowerdeleteall();
            if (check)
            {
                MessageBox.Show("تم حذف الكل", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لم يتم حذف الكل ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            frm_Borroewars_Load(null, null);
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            row = 0;
            borPresenter.getrow(row);
        }

        private void btn_priv_Click(object sender, EventArgs e)
        {
            try
            {
                int countrow = Convert.ToInt32(borPresenter.Getlastrow().Rows[0][0]) - 1;
                if (row == 0)
                {
                    row = countrow;
                }
                else
                {
                    row = row - 1;

                }

                borPresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {

            try
            {
                int countrow = Convert.ToInt32(borPresenter.Getlastrow().Rows[0][0]);
                if (countrow == row)
                {
                    row = 0;
                }
                else
                {
                    row = row + 1;

                }

                borPresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            try
            {
                int countlastrow = Convert.ToInt32(borPresenter.Getlastrow().Rows[0][0]) - 1;
                row = countlastrow;

                borPresenter.getrow(row);
            }
            catch (Exception) { }
        }
    }
}