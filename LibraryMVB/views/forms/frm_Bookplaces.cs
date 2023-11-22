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
    public partial class frm_Bookplaces : DevExpress.XtraEditors.XtraForm,IBookPlace
    {
     

        public int ID { get => Convert.ToInt32(txt_ID.Text); set => txt_ID.Text = value.ToString(); }
        public string Catname { get => Convert.ToString(txt_Name.Text); set => txt_Name.Text = value.ToString(); }
        public object dataGridView { get => Dgv_search.DataSource; set => Dgv_search.DataSource = value; }
         int IBookPlace.row { get => row; set => row=value; }
        object IBookPlace.btn_add { get => btn_add.Enabled; set => btn_add.Enabled = Convert.ToBoolean(value); }
        object IBookPlace.btn_new { get => btn_new.Enabled; set => btn_new.Enabled = Convert.ToBoolean(value); }
        object IBookPlace.btn_save { get => btn_save.Enabled; set => btn_save.Enabled = Convert.ToBoolean(value); }
        object IBookPlace.btn_delete { get => btn_delete.Enabled; set => btn_delete.Enabled = Convert.ToBoolean(value); }
        object IBookPlace.btn_deleteall { get => btn_deleteall.Enabled; set => btn_deleteall.Enabled = Convert.ToBoolean(value); }

      public int row ;
        BookPlacePresenter bookplacepresenter;
        public frm_Bookplaces()
        {
            InitializeComponent();
            bookplacepresenter = new BookPlacePresenter(this);
        }
        private void frm_Bookplaces_Load(object sender, EventArgs e)
        {
         
            bookplacepresenter.AutoNumber();
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المكان", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool check = bookplacepresenter.bookplaceinsert();
            if (check)
            {
                bookplacepresenter.AutoNumber();
                MessageBox.Show("تم اضافة المكان ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم اضافة المكان ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            //catpresenter.clearfiledes();
            bookplacepresenter.AutoNumber();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المكان", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool check = bookplacepresenter.bookplaceupdate();
            if (check)
            {
                bookplacepresenter.AutoNumber();

                MessageBox.Show("تم التعديل", "");
            }
            else
            {
                MessageBox.Show("لم يتم التعديل ", "");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool check = bookplacepresenter.bookplaceDelete();
            if (check)
            {
                bookplacepresenter.AutoNumber();
                MessageBox.Show("تم الحذف", "");
            }
            else
            {
                MessageBox.Show("لم يتم الحذف ", "");
            }
        }

        private void btn_deleteall_Click(object sender, EventArgs e)
        {
            bool check = bookplacepresenter.bookplaceDeleteall();
            if (check)
            {
                bookplacepresenter.AutoNumber();
                MessageBox.Show("تم الحذف", "");
            }
            else
            {
                MessageBox.Show("لم يتم الحذف ", "");
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            try
            {
                row = 0;
                bookplacepresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_priv_Click(object sender, EventArgs e)
        {
            try
            {
                int countrow = Convert.ToInt32(bookplacepresenter.Getlastrow().Rows[0][0]) - 1;
                if (row == 0)
                {
                    row = countrow;
                }
                else
                {
                    row = row - 1;

                }

                bookplacepresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                int countrow = Convert.ToInt32(bookplacepresenter.Getlastrow().Rows[0][0]) - 1;
                if (countrow == row)
                {
                    row = 0;
                }
                else
                {
                    row = row + 1;

                }

                bookplacepresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            try
            {
                int countlastrow = Convert.ToInt32(bookplacepresenter.Getlastrow().Rows[0][0]) - 1;
                row = countlastrow;

                bookplacepresenter.getrow(row);
            }
            catch (Exception) { }
        }
    }
    }
