using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVB.views.Interfaace
{
    interface IAuthors
    {
        int Row { get; set; }

        int ID { get; set; }
        string Authorname { get; set; }
        string AuthorDate { get; set; }
        int CountryID { get; set; }
        string AuthorDisplaymember { get; set; }
        string Authorvaluemember { get; set; }
        object dataGridView { get; set; }
        object cbxcountry { get; set; }

        object btn_add { get; set; }
        object btn_new { get; set; }
        object btn_save { get; set; }
        object btn_delete { get; set; }
        object btn_deleteall { get; set; }
        //للوقوف علي اول خيار في (cbx)
        int SelectedIndex { get; set; }
        //******   **\\
        int Selectedvalue { get; set; }

    }
}
