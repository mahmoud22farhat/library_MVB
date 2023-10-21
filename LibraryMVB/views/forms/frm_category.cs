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

        categorypresenter catpresenter;
        public frm_category()
        {
            InitializeComponent();
            catpresenter = new categorypresenter(this);
        }

       
        private void frm_category_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           bool check = catpresenter.CatInsert();
            if (check)
            {
                MessageBox.Show("تم الاضافة", "");
            }
            else
            {
                MessageBox.Show("هناك خطأ ", "");
            }
        }
    }
}