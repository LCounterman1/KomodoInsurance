using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance_Repository
{
    public class Developer
    {
        //Create List of employees names and id's
        public int DeveloperID { get; set; }
        public string DeveloperName { get; set; }
        public string AccessToPluralsight { get; set; }

        public Developer() { }

        public Developer(int developerID, string developerName, string accessToPluralSight)
        {
            DeveloperID = developerID;
            DeveloperName = developerName;
            AccessToPluralsight = accessToPluralSight;
        }

    }

}
