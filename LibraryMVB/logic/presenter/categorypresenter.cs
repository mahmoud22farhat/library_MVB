using System;
using System.Collections.Generic;
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
            return CategoryServices.categoryinsert(catmodel.ID, catmodel.Catname);
        }
    }
}
