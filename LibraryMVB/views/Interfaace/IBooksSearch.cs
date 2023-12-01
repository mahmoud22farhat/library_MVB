using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVB.views.Interfaace
{
    interface IBooksSearch
    {
        object DGVsearch { get; set; }
        int bookID { get; set; }
        int catID { get; set; }
        object cbxbooks { get; set; }
        string cbxBooksDisplaymember { get; set; }
        string cbxBooksvaluemember { get; set; }

       
        object cbxcat { get; set; }
        string cbxcatDisplaymember { get; set; }
        string cbxcatvaluemember { get; set; }
    }
}
