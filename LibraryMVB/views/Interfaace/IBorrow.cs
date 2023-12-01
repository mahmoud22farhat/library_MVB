using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVB.views.Interfaace
{
    interface IBorrow
    {
        int Row { get; set; }

        int ID { get; set; }
        int BookID { get; set; }
        int borrowID { get; set; }
        string StartDate { get; set; }
        string EndDate { get; set; }
        string Notes { get; set; }


        object btn_add { get; set; }
        object btn_new { get; set; }
        object btn_save { get; set; }
        object btn_delete { get; set; }
        object btn_deleteall { get; set; }

        object cbxBorrowDatasource { get; set; }
        string BorrowDisplaymember { get; set; }
        string Borrowvaluemember { get; set; }
        int SelectedIndexBorrow { get; set; }

        object cbxBookDatasource { get; set; }
        string BookDisplaymember { get; set; }
        string Bookvaluemember { get; set; }
        int SelectedIndexBook { get; set; }











    }
}
