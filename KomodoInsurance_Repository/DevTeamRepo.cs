using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance_Repository
{
    public class DevTeamRepo
    {
        //new instance of developer list
        public List<DevTeam> _devTeam = new List<DevTeam>();

        //CRUD
        //Create devTeams

        public bool CreateDevTeam(DevTeam devTeam)
        {

            int startingCount = _devTeam.Count;
            _devTeam.Add(devTeam);

            bool wasAdded = _devTeam.Count > startingCount ? true : false;
            return wasAdded;
        }
        public bool CreateDevTeamByID(DevTeam devTeamID)
        {

            int startingCount = _devTeam.Count;
            _devTeam.Add(devTeamID);

            bool wasAdded = _devTeam.Count > startingCount ? true : false;
            return wasAdded;
        }

        //Read devTeams
        public List<DevTeam> GetAllDevTeams()
        {
            return _devTeam;
        }

        //Find devTeam
        public DevTeam GetDevTeamByTeamName(string teamName)
        {
            foreach (DevTeam devTeam in _devTeam)
            {
                if (devTeam.TeamName.ToLower() == teamName.ToLower())
                {
                    return devTeam;
                }
            }
            return null;
        }

        public DevTeam GetDevTeamByID(int devTeamID)
        {
            //search for a developer
            foreach (DevTeam devID in _devTeam)
            {
                if (devID.TeamID == devTeamID)
                {
                    return devID;
                }
            }
            return null;
        }


        //Delete DevTeam

        public bool DeleteExistingDevTeam(DevTeam existingTeam)
        {
            bool deleteResult = _devTeam.Remove(existingTeam);
            return deleteResult;
        }

    }
}
