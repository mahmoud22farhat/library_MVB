using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVB.views.Interfaace
{
    interface IdarNashr
    {
        int Row { get; set; }

        int ID { get; set; }
        string DarNashrname { get; set; }
        int CountryID { get; set; }
        //العنصر الذي سيتم عرضه في 
        string DarNashrDisplaymember { get; set; }
        //العنصر الذي سيتم تخذينه ف
        string DarNashrvaluemember { get; set; }
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
