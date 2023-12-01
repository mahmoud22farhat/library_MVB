using LibraryMVB.logic.services;
using LibraryMVB.modles;
using LibraryMVB.views.Interfaace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVB.logic.presenter
{
    class BooksSearchPresenter
    {

        IBooksSearch ibookssearch;
        BooksSearchModel booksearchModel;
        public BooksSearchPresenter(IBooksSearch view)
        {
            this.ibookssearch = view;
        }
        //connect Between AuthorsModel and interfacecat
        private void connectBetweenModelinterface()
        {
            booksearchModel.bookID = ibookssearch.bookID;
          

        }
        public void fillDGV()
        {
            ibookssearch.DGVsearch = BooksSearchServices.getallBooks();         
        }

        public void fillDGVByID()
        {
            
            ibookssearch.DGVsearch = BooksSearchServices.getallBooksByid(ibookssearch.bookID);
        }
        public void fillDGVBycat()
        {

            ibookssearch.DGVsearch = BooksSearchServices.getallBooksBycat(ibookssearch.catID);
        }


        public void fillcbxBooks()
        {

            ibookssearch.cbxbooks = BookDataSevices.getallBooks();
            ibookssearch.cbxBooksDisplaymember = "Book_Name";
            ibookssearch.cbxBooksvaluemember = "ID";

        }
        public void fillcbxCategory()
        {

            ibookssearch.cbxcat = BookDataSevices.getallCategorydata();
            ibookssearch.cbxcatDisplaymember = "اسم التصنيف";
            ibookssearch.cbxcatvaluemember = "رقم التصنيف";

        }
    }
}
