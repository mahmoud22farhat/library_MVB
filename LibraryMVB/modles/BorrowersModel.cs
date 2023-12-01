using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVB.modles
{
    public class BorrowersModel
    {
        public int ID { get; set; }
        public int row { get; set; }
        public string borname { get; set; }
        public string borphone { get; set; }
       public string boraddres { get; set; }
        public string bornote { get; set; }

        object btn_add { get; set; }
         public object btn_new { get; set; }
        public object btn_save { get; set; }
        public object btn_delete { get; set; }
         public object btn_deleteall { get; set; }
    }
}
