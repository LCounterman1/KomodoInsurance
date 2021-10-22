using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance_Repository
{
    
    public class DeveloperRepo
    {
        //new instance of developer list

        public List<Developer> _developerDirectory = new List<Developer>();

        //CRUD
        //Create

        public bool AddDeveloperToDirectory(Developer developer)
        {
            int startingCount = _developerDirectory.Count;
            _developerDirectory.Add(developer);

            bool wasAdded = _developerDirectory.Count > startingCount ? true : false;
            return wasAdded;
        }


        //Read

        public List<Developer> GetAllDevelopers()
        {
            return _developerDirectory;
        }   

        //find the developer by ID
        public Developer GetDeveloperByID(int developerID)
        {
            //search for a developer
            foreach (Developer developer in _developerDirectory)
            {
                if (developer.DeveloperID == developerID)
                {
                    return developer;
                }
            }
            return null;
        }


        //Update
       public bool UpdateExistingDeveloper(int originalDeveloperID, Developer newDeveloper)
        {
            Developer oldDeveloper = GetDeveloperByID(originalDeveloperID);

            if(oldDeveloper != null)
            {
                oldDeveloper.DeveloperID = newDeveloper.DeveloperID;
                oldDeveloper.DeveloperName = newDeveloper.DeveloperName;
                oldDeveloper.AccessToPluralsight = newDeveloper.AccessToPluralsight;
                return true;
            }
            else
            {
                return false;
            }

           
        }






    }
}
