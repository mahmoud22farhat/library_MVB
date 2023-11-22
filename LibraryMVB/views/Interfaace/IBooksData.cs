using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVB.views.Interfaace
{
    interface IBooksData
    {
        int Row { get; set; }

        int ID { get; set; }
        string BookName { get; set; }
        int CatID { get; set; }
     
        int AuthorID { get; set; }
        int CountryID { get; set; }
        int DarID { get; set; }
        string SupCat { get; set; }

        string Date { get; set; }
        int PageNumper { get; set; }
        int PlaceID { get; set; }
        string Bookstatu { get; set; }
        decimal BookPrice { get; set; }
        string Notes { get; set; }

        //this variables to store cbxDatasoursece properties

        object cbxcountry { get; set; }
        object cbxCat { get; set; }
        object cbxPlace { get; set; }
        object cbxDarNashr { get; set; }
        object cbxBooks { get; set; }
        object cbxAuthor { get; set; }
        //this variables to store display member and value member in cbx
        string cbxcountryDisplaymember { get; set; }
        string cbxcountryvaluemember { get; set; }

        string cbxCatDisplaymember { get; set; }
        string cbxCatvaluemember { get; set; }

        string cbxPlaceDisplaymember { get; set; }
        string cbxPlacevaluemember { get; set; }

        string cbxDarNashrDisplaymember { get; set; }
        string cbxDarNashrvaluemember { get; set; }

        string cbxBooksDisplaymember { get; set; }
        string cbxBooksvaluemember { get; set; }

        string cbxAuthorDisplaymember { get; set; }
        string cbxAuthorvaluemember { get; set; }
        //this variable to store selected value and selected index to cbx
        int cbxcountrySelectedIndex { get; set; }
        int cbxcountrySelectedvalue { get; set; }

        int cbxCatSelectedIndex { get; set; }
        int cbxCatSelectedvalue { get; set; }

        int cbxPlaceSelectedIndex { get; set; }
        int cbxPlaceSelectedvalue { get; set; }

        int cbxDarNashrSelectedIndex { get; set; }
        int cbxDarNashrSelectedvalue { get; set; }

        int cbxBooksSelectedIndex { get; set; }
        int cbxBooksSelectedvalue { get; set; }

        int cbxAuthorSelectedIndex { get; set; }
        int cbxAuthorSelectedvalue { get; set; }

        bool btn_add { get; set; }
        bool btn_new { get; set; }
        bool btn_save { get; set; }
        bool btn_delete { get; set; }
        bool btn_deleteall { get; set; }
     
    }
}
