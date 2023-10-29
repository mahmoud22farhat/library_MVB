using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryMVB.logic.services;
using LibraryMVB.modles;
using LibraryMVB.views.Interfaace;
namespace LibraryMVB.logic.presenter
{
    class categorypresenter
    {
        ICategory Icategory;
        CategoryModel catmodel = new CategoryModel();


        public categorypresenter(ICategory view)
        {
            this.Icategory = view;
        }
        //connect Between Modelcat and interfacecat
        private void connectBetweenModelinterface()
        {
            catmodel.ID = Icategory.ID;
            catmodel.Catname = Icategory.Catname;
            
        }
        public bool CatInsert()
        {
            connectBetweenModelinterface();
            bool sheck = CategoryServices.categoryinsert(catmodel.ID, catmodel.Catname);
            getalldata();
            AutoNumber();
            return sheck;
        }
        public bool CatUpdate()
        {
            connectBetweenModelinterface();
            bool sheck= CategoryServices.categoryupdate(catmodel.ID, catmodel.Catname);
            getalldata();
            AutoNumber();
            return sheck;

        }
        public bool CatDelete()
        {
            connectBetweenModelinterface();
            bool sheck= CategoryServices.categorydelete(catmodel.ID);
            getalldata();
            AutoNumber();
            return sheck;
        }
        public bool CatDeleteall()
        {
            connectBetweenModelinterface();
            bool sheck = CategoryServices.categorydeleteall();
            getalldata();
            AutoNumber();
            return sheck;
        }
        public void clearfiledes()
        {
            connectBetweenModelinterface();
            (Icategory.ID) = 0;
            Icategory.Catname = "";
        }
        public void getalldata()
        {
            //   connectBetweenModelinterface();
            Icategory.dataGridView = CategoryServices.getalldata();
            //   return CategoryServices.getalldata();
        }
        public void AutoNumber()
        {
            //to get bigger id in table
            //icountry.ID = CategoryServices.getalldata().Rows.Count +1;
            //to get next bigger id in table
            string test = CategoryServices.getMaxID().Rows[0][0].ToString();
            if (test == null || test == "")
            {
                Icategory.ID = 1;
            }
            else
            {
                Icategory.ID = Convert.ToInt32(CategoryServices.getMaxID().Rows[0][0]) + 1;
            }
            Icategory.Catname = "";
            Icategory.btn_save = false;
            Icategory.btn_delete = false;
            Icategory.btn_deleteall = false;
            Icategory.btn_add = true;

        }
        public void getrow(int row)
        {
            DataTable tbl = new DataTable();
            tbl = CategoryServices.getalldata();
            Icategory.ID = Convert.ToInt32(tbl.Rows[row][0]);
            Icategory.Catname = Convert.ToString(tbl.Rows[row][1]);

            Icategory.btn_save = true;
            Icategory.btn_delete = true;
            Icategory.btn_deleteall = true;
            Icategory.btn_add = false;
        }
        //this method to get lastrowo show in DGV

        public DataTable Getlastrow()
        {
            DataTable tbl = new DataTable();
            tbl = CategoryServices.getlastrow();
            return tbl;
        }
    }
}
