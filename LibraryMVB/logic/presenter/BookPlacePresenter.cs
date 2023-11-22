using LibraryMVB.modles;

using LibraryMVB.views.Interfaace;
using LibraryMVB.logic.services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LibraryMVB.logic.presenter
{
    class BookPlacePresenter
    {
        IBookPlace IbookPlace;
        BookPlaceModel bookplacemodel = new BookPlaceModel();


        public BookPlacePresenter(IBookPlace i)
        {
            this.IbookPlace = i;
        }
        //connect Between Modelcat and interfacecat
        private void connectBetweenModelinterface()
        {
            bookplacemodel.ID = IbookPlace.ID;
            bookplacemodel.Catname = IbookPlace.Catname;

        }
        public void ShowInDataGridView()
        {
         
            IbookPlace.dataGridView = BookPlaceServices.getalldata();
            
        }
        public void AutoNumber()
        {
            
            string test = BookPlaceServices.getMaxID().Rows[0][0].ToString();
            if (test == null || test == "")
            {
                IbookPlace.ID = 1;
                
            }
            else
            {
                IbookPlace.ID = Convert.ToInt32(BookPlaceServices.getMaxID().Rows[0][0]) + 1;
            }
            IbookPlace.Catname = "";
            IbookPlace.btn_save = false;
            IbookPlace.btn_delete = false;
            IbookPlace.btn_deleteall = false;
            IbookPlace.btn_add = true;
            ShowInDataGridView();

        }
        public bool bookplaceinsert()
        {
           
            connectBetweenModelinterface();
          return    BookPlaceServices.bookpalceinsert(bookplacemodel.ID, bookplacemodel.Catname);
           
        }
        public bool bookplaceupdate()
        {

            connectBetweenModelinterface();
            return BookPlaceServices.bookpalceupdate(bookplacemodel.ID, bookplacemodel.Catname);

        }
        public bool bookplaceDelete()
        {

            connectBetweenModelinterface();
            return BookPlaceServices.bookpalcedelete(bookplacemodel.ID);

        }
        public bool bookplaceDeleteall()
        {

            connectBetweenModelinterface();
            return BookPlaceServices.bookplacedeleteall();

        }

        public void getrow(int row)
        {
            DataTable tbl = new DataTable();
            tbl = BookPlaceServices.getalldata();
            IbookPlace.ID = Convert.ToInt32(tbl.Rows[row][0]);
            IbookPlace.Catname = Convert.ToString(tbl.Rows[row][1]);

            IbookPlace.btn_save = true;
            IbookPlace.btn_delete = true;
            IbookPlace.btn_deleteall = true;
            IbookPlace.btn_add = false;
        }
        //this method to get lastrowo show in DGV

        public DataTable Getlastrow()
        {
            DataTable tbl = new DataTable();
            tbl = BookPlaceServices.getlastrow();
            return tbl;
        }
    }
}
