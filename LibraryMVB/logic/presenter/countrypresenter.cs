using LibraryMVB.views.Interfaace;
using LibraryMVB.modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryMVB.logic.services;
using System.Data;

namespace LibraryMVB.logic.presenter
{
    class countrypresenter
    {
        Icountry icountry;
        CountryModel countrymodel = new CountryModel();

        public countrypresenter(Icountry view)
        {
            this.icountry = view;
        }
        //connect Between Modelcat and interfacecat
        private void connectBetweenModelinterface()
        {
            countrymodel.ID = icountry.ID;
            countrymodel.Countryname = icountry.Countryname;

        }
        public bool CountryInsert()
        {
            connectBetweenModelinterface();
           bool sheck =countryservice.countryinsert(countrymodel.ID, countrymodel.Countryname );
            getalldata();
            AutoNumber();
            return sheck;
           
        }
        public bool countryUpdate()
        {
            connectBetweenModelinterface();
            bool sheck =  countryservice.countryupdate(countrymodel.ID, countrymodel.Countryname);
            getalldata();
            AutoNumber();
            return sheck;
           ;
        }
        public bool countryDelete()
        {
            connectBetweenModelinterface();
            bool sheck = countryservice.countrydelete(countrymodel.ID);
            getalldata();
            AutoNumber();
            return sheck;
           
        }
        public bool countryDeleteall()
        {
            connectBetweenModelinterface();
            bool sheck = countryservice.countrydeleteall();
            getalldata();
            AutoNumber();
            return sheck;
            
        }
        public void clearfiledes()
        {
            connectBetweenModelinterface();
            (icountry.ID) = 0;
            icountry.Countryname = "";
            
        }
        public void getalldata()
        {
            //   connectBetweenModelinterface();
            icountry.dataGridView = countryservice.getalldata();
         //   return countryservice.getalldata();
        }
        public void AutoNumber ()
        {
            //to get bigger id in table
            //icountry.ID = countryservice.getalldata().Rows.Count +1;
            //to get next bigger id in table
            string test = countryservice.getMaxID().Rows[0][0].ToString();
            if (test == null || test == "")
            {
                icountry.ID = 1;
            }
            else
            {
                icountry.ID = Convert.ToInt32(countryservice.getMaxID().Rows[0][0]) + 1;
            }
            icountry.Countryname = "";
            icountry.btn_save = false;
            icountry.btn_delete = false;
            icountry.btn_deleteall = false;
            icountry.btn_add = true;

        }
        public void getrow(int row)
        {
            DataTable tbl = new DataTable();
            tbl = countryservice.getalldata();
            icountry.ID = Convert.ToInt32(tbl.Rows[row][0]);
            icountry.Countryname = Convert.ToString(tbl.Rows[row][1]);

            icountry.btn_save = true;
            icountry.btn_delete = true;
            icountry.btn_deleteall = true;
            icountry.btn_add = false;
        }
        //this method to get lastrowo show in DGV

        public DataTable Getlastrow()
        {
            DataTable tbl = new DataTable();
            tbl = countryservice.getlastrow();
            return tbl;
        }
        }
}

