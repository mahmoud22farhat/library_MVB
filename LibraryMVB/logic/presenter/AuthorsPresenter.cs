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
    class AuthorsPresenter
    {
        IAuthors iAuthors;
        AuthorsModel authorsModel = new AuthorsModel();

        public AuthorsPresenter(IAuthors view)
        {
            this.iAuthors = view;
        }
        //connect Between AuthorsModel and interfacecat
        private void connectBetweenModelinterface()
        {
            authorsModel.ID = iAuthors.ID;
            authorsModel.Authorname = iAuthors.Authorname;
            authorsModel.AuthorDate = iAuthors.AuthorDate;
            authorsModel.CountryID = iAuthors.CountryID;

        }
        public void fillcbx()
        {

            iAuthors.cbxcountry = AuthorServices.getalldata();
            iAuthors.AuthorDisplaymember = "اسم الدولة";
            iAuthors.Authorvaluemember = "رقم الدولة";

        }
        public bool AuthorsInsert()
        {
            connectBetweenModelinterface();
            //bool sheck = AuthorServices.Authorsinsert(authorsModel.ID, authorsModel.Authorname, authorsModel.AuthorDate, authorsModel.CountryID);
            //getalldata();
            //AutoNumber();
            //return sheck;
            DateTime d1 =Convert.ToDateTime(authorsModel.AuthorDate);
            string d2 = d1.ToString("dd/MM/yyyy");
           return AuthorServices.Authorsinsert(authorsModel.ID, authorsModel.Authorname, d2, authorsModel.CountryID);

        }
        public bool AuthorsUpdate()
        {
            connectBetweenModelinterface();
           
            DateTime d1 = Convert.ToDateTime(authorsModel.AuthorDate);
            string d2 = d1.ToString("dd/MM/yyyy");
            return AuthorServices.AuthorsUpdate(authorsModel.ID, authorsModel.Authorname, d2, authorsModel.CountryID);

        }

        public void AutoNumber()
        {
            string val = Convert.ToString(AuthorServices.getauthormaxid().Rows[0][0]);
            if(val==null||val=="")
            {
                iAuthors.ID = 1;
            }
            else
            {
                iAuthors.ID = Convert.ToInt32(AuthorServices.getauthormaxid().Rows[0][0]) + 1;
            }
          //  iAuthors.ID = Convert.ToInt32(AuthorServices.getauthormaxid().Rows[0][0])+1;
            iAuthors.Authorname = "";
            iAuthors.AuthorDate = DateTime.Now.ToShortDateString();
            iAuthors.SelectedIndex = 0;

            iAuthors.dataGridView = AuthorServices.getallauthordata();



            iAuthors.btn_save = false;
            iAuthors.btn_delete = false;
            iAuthors.btn_deleteall = false;
            iAuthors.btn_add = true;

        }
        //this method to get lastrowo show in DGV

        public DataTable Getlastrow()
        {
            DataTable tbl = new DataTable();
            tbl = AuthorServices.getlastrow();
            return tbl;
        }
        public void getrow(int row)
        {
            DataTable tbl = new DataTable();
            tbl = AuthorServices.getallauthordatacountryid(); 
            iAuthors.ID = Convert.ToInt32(tbl.Rows[row][0]);
            iAuthors.Authorname = Convert.ToString(tbl.Rows[row][1]);
            try
            {
                DateTime dt = DateTime.ParseExact(Convert.ToString(tbl.Rows[row][2]), "dd/MM/yyyy", null);


                iAuthors.AuthorDate = dt.ToString();
            }
            catch (Exception) { }
            iAuthors.Selectedvalue = Convert.ToInt32(tbl.Rows[row][3]);


            iAuthors.btn_save = true;
            iAuthors.btn_delete = true;
            iAuthors.btn_deleteall = true;
            iAuthors.btn_add = false;
        }

        public bool DeleteAuthor()
        {

          connectBetweenModelinterface();
            bool sheck = AuthorServices.deleteAuthor(authorsModel.ID);
           
            AutoNumber();
            return sheck;
        }
        public bool DeleteallAuthor()
        {

            connectBetweenModelinterface();
            bool sheck = AuthorServices.deleteallAuthor();
         
            AutoNumber();
            return sheck;
        }
    }
}
