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

    public partial class frm_BooksSearch : DevExpress.XtraEditors.XtraForm,IBooksSearch
    {

        object IBooksSearch.DGVsearch { get => DGVsearch.DataSource; set => DGVsearch.DataSource=value; }
        public int bookID { get =>Convert.ToInt32(cbx_Books.SelectedValue); set => cbx_Books.SelectedValue=Convert.ToInt32(value); }
        public object cbxbooks { get => cbx_Books.DataSource; set => cbx_Books.DataSource = value; }
        public string cbxBooksDisplaymember { get =>  cbx_Books.DisplayMember     ; set => cbx_Books.DisplayMember=value; }
        public string cbxBooksvaluemember { get => cbx_Books.ValueMember; set => cbx_Books.ValueMember = value; }
        public object cbxcat { get => cbx_Cat.DataSource; set => cbx_Cat.DataSource=value; }
        public string cbxcatDisplaymember { get =>  cbx_Cat.DisplayMember     ; set => cbx_Cat.DisplayMember=value; }
        public string cbxcatvaluemember { get => cbx_Cat.ValueMember; set => cbx_Cat.ValueMember=value; }
        public int catID { get => Convert.ToInt32(cbx_Cat.SelectedValue); set => cbx_Cat.SelectedValue = Convert.ToInt32(value); }

        BooksSearchPresenter bookspresenter;
        public frm_BooksSearch()
        {
            InitializeComponent();
            bookspresenter = new BooksSearchPresenter(this);
        }
      

        private void frm_BooksSearch_Load(object sender, EventArgs e)
        {
            bookspresenter.fillcbxBooks();
            bookspresenter.fillcbxCategory();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (rbtn_all.Checked == true)
            {
                bookspresenter.fillDGV();
            }else if (rbtnonebook.Checked == true)
            {
                bookspresenter.fillDGVByID();
            } else if (Rbtn_CAT.Checked == true)
            {
                bookspresenter.fillDGVBycat();
            }

        }
    }
}