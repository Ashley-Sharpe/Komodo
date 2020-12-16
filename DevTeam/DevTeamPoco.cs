using Developer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam
{
    public class DevTeamPoco
    {
        public string TeamName { get; set; }
        public List<DeveloperPoco>_listOfDevelopers { get; set; }
        public int ID { get; set; }


        public DevTeamPoco() { }

        public DevTeamPoco(string teamName, int iD)
        {
            TeamName = teamName;
            ID = iD;
        }
    }
}
