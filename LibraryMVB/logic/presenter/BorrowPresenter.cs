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
    class BorrowPresenter
    {
        IBorrow iborrow;
       

        BorrowModel borrowmodel = new BorrowModel();

        public BorrowPresenter(IBorrow view)
        {
            this.iborrow = view;
        }
        //connect Between BookDataModel and interfacecat
        private void connectBetweenModelinterface()
        {
            borrowmodel.ID = iborrow.ID;
            borrowmodel.BookID = iborrow.BookID;
            borrowmodel.borrowID = iborrow.borrowID;
            borrowmodel.StartDate = iborrow.StartDate;
            borrowmodel.EndDate = iborrow.EndDate;
            borrowmodel.Notes = iborrow.Notes;
           
           

        }
        public void AutoNumber()
        {
            string val = Convert.ToString(BorrowServices.getmaxid().Rows[0][0]);
            if (val == null || val == "")
            {
                iborrow.ID = 1;
            }
            else
            {
                iborrow.ID = Convert.ToInt32(BorrowServices.getmaxid().Rows[0][0]) + 1;
            }
            //  iAuthors.ID = Convert.ToInt32(AuthorServices.getauthormaxid().Rows[0][0])+1;
            iborrow.Notes = "";
            iborrow.StartDate = DateTime.Now.ToShortDateString();
            iborrow.EndDate = DateTime.Now.ToShortDateString();

            iborrow.SelectedIndexBook = 0;
            iborrow.SelectedIndexBorrow = 0;




            iborrow.btn_save = false;
            iborrow.btn_delete = false;
            iborrow.btn_deleteall = false;
            iborrow.btn_add = true;

        }
        public void fillcbxBorrowData()
        {

            iborrow.cbxBorrowDatasource = BorrowServices.getallBooksborrowdata();
            iborrow.BorrowDisplaymember = "اسم المستعير";
            iborrow.Borrowvaluemember = "رقم المستعير";

        }
        public void fillcbxBooksData()
        {

            iborrow.cbxBookDatasource = BookDataSevices.getallBooks();
            iborrow.BookDisplaymember = "Book_Name";
            iborrow.Bookvaluemember = "ID";

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
            tbl = BorrowServices.getallBorrowdatacountryid();
            iborrow.ID = Convert.ToInt32(tbl.Rows[row][0]);
            iborrow.BookID = Convert.ToInt32(tbl.Rows[row][1]);
            iborrow.borrowID = Convert.ToInt32(tbl.Rows[row][2]);

            try
            {
                DateTime startdate = DateTime.ParseExact(Convert.ToString(tbl.Rows[row][3]), "dd/MM/yyyy", null);
                DateTime enddate = DateTime.ParseExact(Convert.ToString(tbl.Rows[row][4]), "dd/MM/yyyy", null);

                iborrow.StartDate = startdate.ToString();
                iborrow.EndDate = enddate.ToString();
            }
            catch (Exception) { }
           
            iborrow.Notes = Convert.ToString(tbl.Rows[row][5]);
          

            iborrow.btn_save = true;
            iborrow.btn_delete = true;
            iborrow.btn_deleteall = true;
            iborrow.btn_add = false;
        }
        public bool BorrowInsert()
        {
            connectBetweenModelinterface();

            DateTime d1 = Convert.ToDateTime(borrowmodel.StartDate);
            DateTime d2 = Convert.ToDateTime(borrowmodel.EndDate);
            string d11 = d1.ToString("dd/MM/yyyy");
            string d222 = d2.ToString("dd/MM/yyyy");
            return BorrowServices.Borrowinsert(borrowmodel.ID, borrowmodel.BookID, borrowmodel.borrowID,d11,d222, borrowmodel.Notes);

        }
        public bool BorrowUpdate()
        {
            connectBetweenModelinterface();
            DateTime d1 = Convert.ToDateTime(borrowmodel.StartDate);
            DateTime d2 = Convert.ToDateTime(borrowmodel.EndDate);
            string d11 = d1.ToString("dd/MM/yyyy");
            string d222 = d2.ToString("dd/MM/yyyy");


            return BorrowServices.Borrowupdate(borrowmodel.ID, borrowmodel.BookID, borrowmodel.borrowID, d11, d222, borrowmodel.Notes);

        }
        public bool BorrowDelete()
        {

            connectBetweenModelinterface();
              return BorrowServices.Borrowdelete(borrowmodel.ID);

            
            
        }
        public bool BorrowDeleteAll()
        {

            connectBetweenModelinterface();
            return BorrowServices.Borrowdeleteall();
        }


    }
}
