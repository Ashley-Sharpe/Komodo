using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance
{
    public class DeveloperRepo
    {
        public List<DeveloperRepo> _listOfDevs = new List<DeveloperRepo>();
        //Create
        public void AddIDToList(DeveloperRepo idNum)
        {
            _listOfDevs.Add(idNum);
        }
        //Read
        public List<DeveloperRepo> GetDeveloperRepo()
        {
            return _listOfDevs;
        }
        //Update

        //Delete
        public void DeleteIDFromList(DeveloperRepo contentID )
        {
            _listOfDevs.Remove(contentID);
        }


        //Helper method
        private DeveloperRepo GetDeveloperByID(int idNum)
        {

        }
    }
}
