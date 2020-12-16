using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer
{
    public class DeveloperPoco
    {
        public string Names { get; set; }
        public int IdNumber { get; set; }
        public bool PluralSight { get; set; }
        DeveloperPoco(string names, int idNum , bool license)
        {
            Names = names;
            IdNumber = idNum;
            PluralSight = license;
        }
    }
}
