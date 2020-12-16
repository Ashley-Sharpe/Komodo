using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance
{
    public class DevTeam
    {
    public string TeamName { get; set; }
    public string Members { get; set; }
    public int ID { get; set; }


    public DevTeam() { }

        public DevTeam(string teamName, string members, int iD)
        {
            TeamName = teamName;
            Members = members;
            ID = iD;
        }
    }


    
}
