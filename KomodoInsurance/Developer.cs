using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance
{
   public class Developer
    {
        public string Names { get; set; }
        public int IdNumber { get; set; }

        Developer(string names, int idNum)
        {
            Names = names;
            IdNumber = idNum;
        }
    }
}
