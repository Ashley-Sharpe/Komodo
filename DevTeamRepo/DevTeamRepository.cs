using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevTeam;

namespace DevTeamRepo
{
    public class DevTeamRepository
    {
   
        private readonly List<DevTeamPoco> _listOfDevs = new List<DevTeamPoco>();
        //Create
        public void AddDevTeamToList(DevTeamPoco devTeam)
        {
            _listOfDevs.Add(devTeam);
        }
        //Read /,
        public List<DevTeamPoco> GetDevTeam()
        {
            return _listOfDevs;
        }
        //Update
        public bool UpdateExistingDevTeam(int originalDev, DevTeamPoco newdev)
        {
            //Find the content
            DevTeamPoco oldDev = GetDevTeamByID(originalDev);

            //Update the content
            if(oldDev != null)
            {
                oldDev.ID = newdev.ID;
                oldDev.TeamName = newdev.TeamName;

                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool DeleteDevTeamFromList(int idNum)
        {
            DevTeamPoco devTeam = GetDevTeamByID(idNum);

            if (devTeam == null)
            {
                return false;
            }

            int initialCount = _listOfDevs.Count;
            _listOfDevs.Remove(devTeam);

            if(initialCount > _listOfDevs.Count)
            {
                return true;
            }

            else
            {
                return false;
            }

        }


        //Helper method
        public DevTeamPoco GetDevTeamByID(int idNum)
        {
            foreach (DevTeamPoco devTeam in _listOfDevs)
            {
                if(devTeam.ID == idNum)
                {
                    return devTeam;
                }

            }
            return null;
        }
    }
}
    

