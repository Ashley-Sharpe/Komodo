using Developer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperRepo
{
    public class DeveloperRepository
    {
        public List<DeveloperPoco> _listOfDeveloperPocos = new List<DeveloperPoco>();
        //Create
        public void AddDeveloperToList(DeveloperPoco developer)
        {
             _listOfDeveloperPocos.Add(developer);


        }
        //Read
        public List<DeveloperPoco> GetDeveloperPoco()
        {
            return _listOfDeveloperPocos;
        }
        //Update 

        //Delete
        public bool RemoveDeveloperFromList(int idNum)
        {
            DeveloperPoco developer = GetDeveloperPoco(idNum);
            
            if (developer == null)
            {
                return false;
            }

           int initialCount = _listOfDeveloperPocos.Count;
            _listOfDeveloperPocos.Remove(developer);

            if(initialCount > _listOfDeveloperPocos.Count)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        //Helper Method
        public DeveloperPoco GetDeveloperPoco(int idNum)
        {
            foreach (DeveloperPoco developer in _listOfDeveloperPocos)
            {
                if (developer.IdNumber == idNum)
                {
                    return developer;
                }
            }
            return null;
        }
    }

}
