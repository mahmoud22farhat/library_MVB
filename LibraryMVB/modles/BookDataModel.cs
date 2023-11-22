using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVB.modles
{
    class BookDataModel
    {
      public  int ID { get; set; }
        public string BookName { get; set; }
        public int CatID { get; set; }
        public int AuthorID { get; set; }
        public int CountryID { get; set; }
        public int DarID { get; set; }
        public string SupCat { get; set; }
        public string Date { get; set; }
        public int PageNumper { get; set; }
        public int PlaceID { get; set; }
        public string Bookstatu { get; set; }
        public decimal BookPrice { get; set; }
        public string Notes { get; set; }
    }
}
