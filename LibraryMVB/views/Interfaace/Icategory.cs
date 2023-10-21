using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVB.views.Interfaace
{
 public interface ICategory
    {
        int ID { get; set; }

        string Catname { get; set; }
    }
}
