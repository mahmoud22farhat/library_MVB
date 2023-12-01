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
    class BorrowersPresenter
    {
        IBorrowers Iborrowers;
        
        BorrowersModel borModel = new BorrowersModel();


        public BorrowersPresenter(IBorrowers view)
        {
            this.Iborrowers = view;
        }
        private void connectBetweenModelinterface()
        {
            borModel.ID = Iborrowers.ID;
            borModel.borname = Iborrowers.borname;
            borModel.borphone = Iborrowers.borphone;
            borModel.boraddres = Iborrowers.boraddres;
            borModel.bornote = Iborrowers.bornote;

        }
        public void AutoNumber()
        {
            string val = Convert.ToString(BorrowerService.getBorrowersmaxid().Rows[0][0]);
            if (val == null || val == "")
            {
                Iborrowers.ID = 1;
            }
            else
            {
                Iborrowers.ID = Convert.ToInt32(BorrowerService.getBorrowersmaxid().Rows[0][0]) + 1;
            }
            //  iAuthors.ID = Convert.ToInt32(AuthorServices.getauthormaxid().Rows[0][0])+1;
            Iborrowers.borname = "";
            Iborrowers.boraddres = "";
            Iborrowers.borphone= "";
            Iborrowers.bornote = "";



            Iborrowers.btn_save = false;
            Iborrowers.btn_delete = false;
            Iborrowers.btn_deleteall = false;
            Iborrowers.btn_add = true;

        }
        public DataTable Getlastrow()
        {
            DataTable tbl = new DataTable();
            tbl = BorrowerService.getlastrow();
            return tbl;
        }
        public void getrow(int row)
        {
            DataTable tbl = new DataTable();
            tbl = BorrowerService.getallBorrowersdatacountryid();
            Iborrowers.ID = Convert.ToInt32(tbl.Rows[row][0]);
            Iborrowers.borname = Convert.ToString(tbl.Rows[row][1]);
            Iborrowers.borphone = Convert.ToString(tbl.Rows[row][2]);
            Iborrowers.boraddres = Convert.ToString(tbl.Rows[row][3]);
            Iborrowers.bornote = Convert.ToString(tbl.Rows[row][4]);

            Iborrowers.btn_save = true;
            Iborrowers.btn_delete = true;
            Iborrowers.btn_deleteall = true;
            Iborrowers.btn_add = false;
        }
        public bool BorrowersInsert()
        {
            connectBetweenModelinterface();
           
            return BorrowerService.Borrowerinsert(borModel.ID, borModel.borname, borModel.borphone, borModel.boraddres, borModel.bornote);

        }
        public bool BorrowerUpdate()
        {
            connectBetweenModelinterface();

            return BorrowerService.Borrowerupdate(borModel.ID, borModel.borname, borModel.borphone, borModel.boraddres, borModel.bornote);


        }
        public bool Borrowerdelete()
        {
            connectBetweenModelinterface();

            return BorrowerService.borrowdelete(borModel.ID);


        }
        public bool Borrowerdeleteall()
        {
            connectBetweenModelinterface();

            return BorrowerService.borrowdeleteall();


        }

    }
}
