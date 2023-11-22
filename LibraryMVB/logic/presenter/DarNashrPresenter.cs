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
    class DarNashrPresenter
    {
        IdarNashr idarNashr;
        DarNashrModel darNashrModel = new DarNashrModel();

        public DarNashrPresenter(IdarNashr view)
        {

            this.idarNashr = view;

        }
        //connect Between darnashrModel and interface
        private void connectBetweenModelinterface()
        {
            darNashrModel.ID = idarNashr.ID;
            darNashrModel.Darname = idarNashr.DarNashrname;
            darNashrModel.CountryID = idarNashr.CountryID;

        }
        public bool DarNashrInsert()
        {
            connectBetweenModelinterface();
            return DarNashrService.darinsert(darNashrModel.ID, darNashrModel.Darname ,darNashrModel.CountryID);
        }
        public bool DarNashrUpdate()
        {
            connectBetweenModelinterface();
            return DarNashrService.darUpdate(darNashrModel.ID, darNashrModel.Darname, darNashrModel.CountryID);
        }
        public bool DarNashrDelete()
        {

            connectBetweenModelinterface();
            return DarNashrService.dardelete(darNashrModel.ID);

        }
        public bool DarNashrDeleteall()
        {
            connectBetweenModelinterface();
            return DarNashrService.dardeleteall();
        }
        public void fillcbx()
        {

            idarNashr.cbxcountry = DarNashrService.getalldatacountry();
            idarNashr.DarNashrDisplaymember = "اسم الدولة";
            idarNashr.DarNashrvaluemember = "رقم الدولة";

        }
        public void AutoNumber()
        {
            string val = Convert.ToString(DarNashrService.getdarNashrmaxid().Rows[0][0]);
            if (val == null || val == "")
            {
                idarNashr.ID = 1;
            }
            else
            {
                idarNashr.ID = Convert.ToInt32(DarNashrService.getdarNashrmaxid().Rows[0][0]) + 1;
            }
            //  iAuthors.ID = Convert.ToInt32(AuthorServices.getauthormaxid().Rows[0][0])+1;
            idarNashr.DarNashrname = "";
            idarNashr.SelectedIndex = 0;

            idarNashr.dataGridView = DarNashrService.getalldardata();



            idarNashr.btn_save = false;
            idarNashr.btn_delete = false;
            idarNashr.btn_deleteall = false;
            idarNashr.btn_add = true;

        }
        //this method to get lastrowo show in DGV

        public DataTable Getlastrow()
        {
            DataTable tbl = new DataTable();
            tbl = DarNashrService.getlastrow();
            return tbl;
        }
        public void getrow(int row)
        {
            DataTable tbl = new DataTable();
            tbl = DarNashrService.getalldardataByid();
            idarNashr.ID = Convert.ToInt32(tbl.Rows[row][0]);
            idarNashr.DarNashrname = Convert.ToString(tbl.Rows[row][1]);
            idarNashr.Selectedvalue = Convert.ToInt32(tbl.Rows[row][2]);

            idarNashr.btn_save = true;
            idarNashr.btn_delete = true;
            idarNashr.btn_deleteall = true;
            idarNashr.btn_add = false;
        }
    }
}
