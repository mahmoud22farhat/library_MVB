﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVB.modles
{
    class BorrowModel
    {

       public int ID { get; set; }
        public int BookID { get; set; }
        public int borrowID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Notes { get; set; }
    }
}
