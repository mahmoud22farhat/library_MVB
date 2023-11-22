using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVB.modles
{
    class AuthorsModel
    {
        public int ID { get; set; }
        public string Authorname { get; set; }
        public string AuthorDate { get; set; }
        public int CountryID { get; set; }
    }
}
