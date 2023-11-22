using LibraryMVB.logic.services;
using LibraryMVB.modles;
using LibraryMVB.views.Interfaace;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVB.logic.presenter
{
    class BookDataPresenter
    {
        IBooksData ibookdata;

        BookDataModel bookdataModel = new BookDataModel();

        public BookDataPresenter(IBooksData view)
        {
            this.ibookdata = view;
        }
        //connect Between BookDataModel and interfacecat
        private void connectBetweenModelinterface()
        {
            bookdataModel.ID = ibookdata.ID;
            bookdataModel.BookName = ibookdata.BookName;
            bookdataModel.CatID = ibookdata.CatID;
            bookdataModel.AuthorID       = ibookdata.AuthorID      ;
            bookdataModel.CountryID = ibookdata.CountryID;
            bookdataModel.DarID = ibookdata.DarID;
            bookdataModel.SupCat   = ibookdata.SupCat      ;
            bookdataModel.Date = ibookdata.Date;
            bookdataModel.PageNumper       = ibookdata.PageNumper      ;
            bookdataModel. PlaceID      = ibookdata. PlaceID     ;
            bookdataModel.    Bookstatu   = ibookdata.Bookstatu      ;
            bookdataModel.    BookPrice   = ibookdata.    BookPrice  ;
            bookdataModel.  Notes     = ibookdata. Notes     ;
           
        }
        public void fillcbxDarNashr()
        {

            ibookdata.cbxDarNashr = BookDataSevices.getallDarNashrdata();
            ibookdata.cbxDarNashrDisplaymember = "اسم الدار";
            ibookdata.cbxDarNashrvaluemember = "رقم الدار";

        }
        public void fillcbxCountry()
        {

            ibookdata.cbxcountry = BookDataSevices.getallCountrydata();
            ibookdata.cbxcountryDisplaymember = "اسم الدولة";
            ibookdata.cbxcountryvaluemember = "رقم الدولة";

        }
        public void fillcbxCategory()
        {

            ibookdata.cbxCat = BookDataSevices.getallCategorydata();
            ibookdata.cbxCatDisplaymember = "اسم التصنيف";
            ibookdata.cbxCatvaluemember = "رقم التصنيف";

        }
        public void fillcbxBookplaceData()
        {

            ibookdata.cbxPlace = BookDataSevices.getallBookplacedata();
            ibookdata.cbxPlaceDisplaymember = "اسم المكان";
            ibookdata.cbxPlacevaluemember = "رقم المكان";

        }
        public void fillcbxAuthorData()
        {

            ibookdata.cbxAuthor = BookDataSevices.getallAuthordata();
            ibookdata.cbxAuthorDisplaymember = "اسم المؤلف";
            ibookdata.cbxAuthorvaluemember = "رقم المؤلف";

        }
        public void fillcbxBooksData()
        {

            ibookdata.cbxBooks = BookDataSevices.getallBooks();
            ibookdata.cbxBooksDisplaymember = "Book_Name";
            ibookdata.cbxBooksvaluemember = "ID";

        }


        public void AutoNumber()
        {
            string val = Convert.ToString(BookDataSevices.getBooksMaxID().Rows[0][0]);
            if (val == null || val == "")
            {
                ibookdata.ID = 1;
            }
            else
            {
                ibookdata.ID = Convert.ToInt32(BookDataSevices.getBooksMaxID().Rows[0][0]) + 1;
            }
            //  iAuthors.ID = Convert.ToInt32(AuthorServices.getauthormaxid().Rows[0][0])+1;
            ibookdata.BookName = "";
            ibookdata.Date = DateTime.Now.ToShortDateString();
            ibookdata.cbxAuthorSelectedIndex = 0;
            ibookdata.cbxBooksSelectedIndex = 0;
            ibookdata.cbxCatSelectedIndex = 0;
            ibookdata.cbxcountrySelectedIndex = 0;
            ibookdata.cbxDarNashrSelectedIndex = 0;
            ibookdata.cbxPlaceSelectedIndex = 0;

            ibookdata.BookPrice = 1;
            ibookdata.PageNumper = 1;
            ibookdata.Notes = "";


            ibookdata.btn_save = false;
            ibookdata.btn_delete = false;
            ibookdata.btn_deleteall = false;
            ibookdata.btn_add = true;

        }
        public DataTable Getlastrow()
        {
            DataTable tbl = new DataTable();
            tbl = BookDataSevices.getlastrow();
            return tbl;
        }
        public void getrow(int row)
        {
            DataTable tbl = new DataTable();
            tbl = BookDataSevices.getallBookdatacountryid();
            ibookdata.ID = Convert.ToInt32(tbl.Rows[row][0]);
            ibookdata.BookName = Convert.ToString(tbl.Rows[row][1]);
            ibookdata.CatID = Convert.ToInt32(tbl.Rows[row][2]);
            ibookdata.AuthorID = Convert.ToInt32(tbl.Rows[row][3]);
            ibookdata.CountryID = Convert.ToInt32(tbl.Rows[row][4]);
            ibookdata.DarID = Convert.ToInt32(tbl.Rows[row][5]);
            ibookdata.SupCat = Convert.ToString(tbl.Rows[row][6]);
            try
            {
                DateTime dt = DateTime.ParseExact(Convert.ToString(tbl.Rows[row][7]), "dd/MM/yyyy", null);


                ibookdata.Date = dt.ToString();
            }
            catch (Exception) { }
            ibookdata.PageNumper = Convert.ToInt32(tbl.Rows[row][8]);
            ibookdata.PlaceID = Convert.ToInt32(tbl.Rows[row][9]);
            ibookdata.Bookstatu = Convert.ToString(tbl.Rows[row][10]);
            ibookdata.BookPrice = Convert.ToInt32(tbl.Rows[row][11]);
            ibookdata.Notes = Convert.ToString(tbl.Rows[row][12]);
            ibookdata.PageNumper = Convert.ToInt32(tbl.Rows[row][8]);
            ibookdata.PageNumper = Convert.ToInt32(tbl.Rows[row][8]);
            ibookdata.PageNumper = Convert.ToInt32(tbl.Rows[row][8]);


            ibookdata.btn_save = true;
            ibookdata.btn_delete = true;
            ibookdata.btn_deleteall = true;
            ibookdata.btn_add = false;
        }
        public bool BookDataInsert()
        {
            connectBetweenModelinterface();
          
            DateTime d1 = Convert.ToDateTime(bookdataModel.Date);
            string d2 = d1.ToString("dd/MM/yyyy");
            return BookDataSevices.Bookdatainsert(bookdataModel.ID, bookdataModel.BookName,bookdataModel.CatID, bookdataModel.AuthorID, bookdataModel.CountryID, bookdataModel.DarID, bookdataModel.SupCat, d2,bookdataModel.PageNumper, bookdataModel.PlaceID, bookdataModel.Bookstatu, bookdataModel.BookPrice, bookdataModel.Notes);

        }
        public bool BookDataUpdate()
        {
            connectBetweenModelinterface();

            DateTime d1 = Convert.ToDateTime(bookdataModel.Date);
            string d2 = d1.ToString("dd/MM/yyyy");
            return BookDataSevices.BookdataUpdate(bookdataModel.ID, bookdataModel.BookName, bookdataModel.CatID, bookdataModel.AuthorID, bookdataModel.CountryID, bookdataModel.DarID, bookdataModel.SupCat, d2, bookdataModel.PageNumper, bookdataModel.PlaceID, bookdataModel.Bookstatu, bookdataModel.BookPrice, bookdataModel.Notes);

        }
        public bool BookDataDelete()
        {

            connectBetweenModelinterface();
            bool sheck = BookDataSevices.Bookdatadelete(bookdataModel.ID);

            AutoNumber();
            return sheck;
        }
        public bool BookDataDeleteAll()
        {

            connectBetweenModelinterface();
            bool sheck = BookDataSevices.BookDatadeleteall();

            AutoNumber();
            return sheck;
        }
    }
}
