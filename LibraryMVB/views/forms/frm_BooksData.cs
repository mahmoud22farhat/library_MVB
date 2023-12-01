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
    public partial class frm_BooksData : DevExpress.XtraEditors.XtraForm,IBooksData
    {
        
        public int Row { get => row; set => row=value; }
        public int ID { get => Convert.ToInt32(txt_ID.Text); set => txt_ID.Text = value.ToString(); }
        public string BookName { get => txt_Name.Text; set => txt_Name.Text = value; }

        public int CatID { get => Convert.ToInt32(cbx_Cat.SelectedValue); set => cbx_Cat.SelectedValue=value; }
        public int AuthorID { get => Convert.ToInt32(cbx_Author.SelectedValue); set => cbx_Author.SelectedValue = value; }
        public int CountryID { get => Convert.ToInt32(cbx_country.SelectedValue); set => cbx_country.SelectedValue = value; }
        public int DarID { get => Convert.ToInt32(cbx_DarNashr.SelectedValue); set => cbx_DarNashr.SelectedValue = value; }

        public string SupCat { get => txt_SupCat.Text; set =>txt_SupCat.Text=value; }



        public string Date { get => dtp_date.Text; set => dtp_date.Text=value; }
        public int PageNumper { get => Convert.ToInt32(Nud_PagesNumper.Value); set => Nud_PagesNumper.Value=value; }
        public int PlaceID { get => Convert.ToInt32(cbx_place.SelectedValue); set => cbx_place.SelectedValue=value; }
        public string Bookstatu { get => txt_Bookstatu.Text; set => txt_Bookstatu.Text=value; }
        public decimal BookPrice { get => Convert.ToInt32(Nud_Booksprice.Value); set => Nud_Booksprice.Value = value; }
        public string Notes { get => txt_Notes.Text; set => txt_Notes.Text=value; }

        public object cbxcountry { get => cbx_country.DataSource; set => cbx_country.DataSource=value; }
        public object cbxCat { get =>  cbx_Cat.DataSource; set => cbx_Cat.DataSource = value; }
        public object cbxPlace { get => cbx_place.DataSource; set => cbx_place.DataSource = value; }
        public object cbxDarNashr { get => cbx_DarNashr.DataSource; set => cbx_DarNashr.DataSource = value; }
        public object cbxBooks { get => cbx_Books.DataSource; set => cbx_Books.DataSource = value; }
        public object cbxAuthor { get => cbx_Author.DataSource; set => cbx_Author.DataSource=value; }


        public string cbxcountryDisplaymember { get => cbx_country.DisplayMember; set => cbx_country.DisplayMember=value; }
        public string cbxcountryvaluemember { get =>cbx_country.ValueMember; set => cbx_country.ValueMember=value; }
        public string cbxCatDisplaymember { get =>cbx_Cat.DisplayMember; set => cbx_Cat.DisplayMember=value; }
        public string cbxCatvaluemember { get => cbx_Cat.ValueMember; set => cbx_Cat.ValueMember=value; }
        public string cbxPlaceDisplaymember { get =>cbx_place.DisplayMember; set => cbx_place.DisplayMember=value; }
        public string cbxPlacevaluemember { get => cbx_place.ValueMember; set => cbx_place.ValueMember=value; }
        public string cbxDarNashrDisplaymember { get =>cbx_DarNashr.DisplayMember ; set => cbx_DarNashr.DisplayMember=value; }
        public string cbxDarNashrvaluemember { get => cbx_DarNashr.ValueMember; set => cbx_DarNashr.ValueMember=value; }
        public string cbxBooksDisplaymember { get => cbx_Books.DisplayMember; set => cbx_Books.DisplayMember=value; }
        public string cbxBooksvaluemember { get => cbx_Books.ValueMember; set => cbx_Books.ValueMember=value; }
        public string cbxAuthorDisplaymember { get => cbx_Author.DisplayMember; set => cbx_Author.DisplayMember = value; }
        public string cbxAuthorvaluemember { get => cbx_Author.ValueMember; set => cbx_Author.ValueMember = value; }

        public int cbxcountrySelectedIndex { get => cbx_country.SelectedIndex; set => cbx_country.SelectedIndex=value; }
        public int cbxcountrySelectedvalue { get => Convert.ToInt32(cbx_country.SelectedValue); set => cbx_country.SelectedValue=value; }
        public int cbxCatSelectedIndex { get => cbx_Cat.SelectedIndex; set => cbx_Cat.SelectedIndex=value; }
        public int cbxCatSelectedvalue { get => Convert.ToInt32(cbx_Cat.SelectedValue); set => cbx_Cat.SelectedValue = value; }
        public int cbxPlaceSelectedIndex { get => cbx_place.SelectedIndex; set => cbx_place.SelectedIndex = value; }
        public int cbxPlaceSelectedvalue { get => Convert.ToInt32(cbx_place.SelectedValue); set => cbx_place.SelectedValue = value; }
        public int cbxDarNashrSelectedIndex { get => cbx_DarNashr.SelectedIndex; set => cbx_DarNashr.SelectedIndex = value; }
        public int cbxDarNashrSelectedvalue { get => Convert.ToInt32(cbx_DarNashr.SelectedValue); set => cbx_DarNashr.SelectedValue = value; }
        public int cbxBooksSelectedIndex { get => bookIndex; set => bookIndex = value; }
        public int cbxBooksSelectedvalue { get => Convert.ToInt32(cbx_Books.SelectedValue); set => cbx_Books.SelectedValue = value; }
        public int cbxAuthorSelectedIndex { get => cbx_Author.SelectedIndex; set => cbx_Author.SelectedIndex = value; }
        public int cbxAuthorSelectedvalue { get => Convert.ToInt32(cbx_Author.SelectedValue); set => cbx_Author.SelectedValue = value; }


        bool IBooksData.btn_add { get => btn_add.Enabled; set => btn_add.Enabled = Convert.ToBoolean(value); }
        bool IBooksData.btn_new { get => btn_new.Enabled; set => btn_new.Enabled = Convert.ToBoolean(value); }
        bool IBooksData.btn_save { get => btn_update.Enabled; set => btn_update.Enabled = Convert.ToBoolean(value); }
        bool IBooksData.btn_delete { get => btn_delete.Enabled; set => btn_delete.Enabled = Convert.ToBoolean(value); }
        bool IBooksData.btn_deleteall { get => btn_deleteall.Enabled; set => btn_deleteall.Enabled = Convert.ToBoolean(value); }
       
       
        public int row; public int bookIndex;
        BookDataPresenter bookdatapresenter;
        public frm_BooksData()
        {
            InitializeComponent();
            bookdatapresenter = new BookDataPresenter(this);

            if(cbx_Books.Items.Count<=0)
            {
                bookIndex = cbx_Books.SelectedIndex;
            }
            else
            {
                bookIndex = cbx_Books.SelectedIndex;
            }
        }
        private void frm_BooksData_Load(object sender, EventArgs e)
        {
            
                bookdatapresenter.fillcbxDarNashr();
                bookdatapresenter.fillcbxCountry();
                bookdatapresenter.fillcbxCategory();
                bookdatapresenter.fillcbxBookplaceData();
                bookdatapresenter.fillcbxAuthorData();
                bookdatapresenter.fillcbxBooksData();

                bookdatapresenter.AutoNumber();
           

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            frm_BooksData_Load(null, null);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الكتاب", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (txt_SupCat.Text == "")
            {
                MessageBox.Show("من فضلك ادخل التصنيف الفرعي للكتاب ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (txt_Bookstatu.Text == "")
            {
                MessageBox.Show("من فضلك ادخل حالة الكتاب   ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            bool check = bookdatapresenter.BookDataInsert();
            if (check)
            {
                MessageBox.Show("تم اضافة الكتاب ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bookdatapresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم اضافة الكتاب ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الكتاب", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (txt_SupCat.Text == "")
            {
                MessageBox.Show("من فضلك ادخل التصنيف الفرعي للكتاب ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (txt_Bookstatu.Text == "")
            {
                MessageBox.Show("من فضلك ادخل حالة الكتاب   ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            bool check = bookdatapresenter.BookDataUpdate();
            if (check)
            {
                MessageBox.Show("تم تعديل الكتاب ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bookdatapresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم تعديل الكتاب ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool check = bookdatapresenter.BookDataDelete();
            if (check)
            {
                MessageBox.Show("تم حذف الكتاب", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لم يتم حذف الكتاب ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_deleteall_Click(object sender, EventArgs e)
        {
            bool check = bookdatapresenter.BookDataDeleteAll();
            if (check)
            {
                MessageBox.Show("تم حذف الكل", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لم يتم حذف الكل ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            row = 0;
            bookdatapresenter.getrow(row);
        }

        private void btn_priv_Click(object sender, EventArgs e)
        {
            try
            {
                int countrow = Convert.ToInt32(bookdatapresenter.Getlastrow().Rows[0][0]) - 1;
                if (row == 0)
                {
                    row = countrow;
                }
                else
                {
                    row = row - 1;

                }

                bookdatapresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                int countrow = Convert.ToInt32(bookdatapresenter.Getlastrow().Rows[0][0]);
                if (countrow == row)
                {
                    row = 0;
                }
                else
                {
                    row = row + 1;

                }

                bookdatapresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            try
            {
                int countlastrow = Convert.ToInt32(bookdatapresenter.Getlastrow().Rows[0][0]) - 1;
                row = countlastrow;

                bookdatapresenter.getrow(row);
            }
            catch (Exception) { }
        }
    }
}