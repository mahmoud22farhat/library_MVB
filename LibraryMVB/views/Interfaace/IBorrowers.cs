using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVB.views.Interfaace
{
   public interface IBorrowers
    {
        int ID { get; set; }
        int row { get; set; }
        string borname { get; set; }
        string borphone { get; set; }
        string boraddres { get; set; }
        string bornote { get; set; }
        
        object btn_add { get; set; }
        object btn_new { get; set; }
        object btn_save { get; set; }
        object btn_delete { get; set; }
        object btn_deleteall { get; set; }
    }
}
