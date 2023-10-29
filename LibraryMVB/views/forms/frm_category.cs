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
    public partial class frm_category : DevExpress.XtraEditors.XtraForm,ICategory
    {

        public int ID { get => Convert.ToInt32(txt_ID.Text); set => txt_ID.Text=value.ToString(); }
        public string Catname { get => Convert.ToString(txt_Name.Text); set => txt_Name.Text = value.ToString(); }
        public object dataGridView { get => Dgv_search.DataSource; set => Dgv_search.DataSource = value; }
        object ICategory.btn_add { get => btn_add.Enabled; set => btn_add.Enabled=Convert.ToBoolean(value);  }
        object ICategory.btn_new { get => btn_new.Enabled; set => btn_new.Enabled=Convert.ToBoolean(value);  }
        object ICategory.btn_save { get => btn_save.Enabled; set => btn_save.Enabled=Convert.ToBoolean(value);  }
        object ICategory.btn_delete { get => btn_delete.Enabled; set => btn_delete.Enabled=Convert.ToBoolean(value);  }
        object ICategory.btn_deleteall { get => btn_deleteall.Enabled; set => btn_deleteall.Enabled=Convert.ToBoolean(value);  }
        int ICategory.row { get => row; set => row = value; }

        int row = 0;
        categorypresenter catpresenter;
        
        public frm_category()
        {
            InitializeComponent();
            catpresenter = new categorypresenter(this);
        }

       
        private void frm_category_Load(object sender, EventArgs e)
        {
            catpresenter.getalldata();
            catpresenter.AutoNumber();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم التصنيف", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool check = catpresenter.CatInsert();
            if (check)
            {
                MessageBox.Show("تم اضافة التصنيف ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم اضافة التصنيف ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool check = catpresenter.CatUpdate();
            if (check)
            {
                MessageBox.Show("تم التعديل", "");
            }
            else
            {
                MessageBox.Show("لم يتم التعديل ", "");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool check = catpresenter.CatDelete();
            if (check)
            {
                MessageBox.Show("تم الحذف", "");
            }
            else
            {
                MessageBox.Show("لم يتم الحذف ", "");
            }
        }

        private void btn_deleteall_Click(object sender, EventArgs e)
        {
            bool check = catpresenter.CatDeleteall();
            if (check)
            {
                MessageBox.Show("تم الحذف", "");
            }
            else
            {
                MessageBox.Show("لم يتم الحذف ", "");
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            catpresenter.clearfiledes();
            catpresenter.AutoNumber();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {

            try
            {
                row = 0;
                catpresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_priv_Click(object sender, EventArgs e)
        {
            try
            {
                int countrow = Convert.ToInt32(catpresenter.Getlastrow().Rows[0][0]) - 1;
                if (row == 0)
                {
                    row = countrow;
                }
                else
                {
                    row = row - 1;

                }

                catpresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
             try
            {
                int countrow = Convert.ToInt32(catpresenter.Getlastrow().Rows[0][0]) - 1;
                if (countrow ==row )
                {
                    row =0 ;
                }
                else
                {
                    row = row + 1;

                }

                catpresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            try
            {
                int countlastrow = Convert.ToInt32(catpresenter.Getlastrow().Rows[0][0]) - 1;
                row = countlastrow;

                catpresenter.getrow(row);
            }
            catch (Exception) { }
        }
    }
    }

