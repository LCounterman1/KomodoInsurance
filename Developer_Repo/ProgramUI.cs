using KomodoInsurance_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance_Console
{
    public class ProgramUI
    {
        public DevTeamRepo _devTeam = new DevTeamRepo();
        public DeveloperRepo _developerDirectory = new DeveloperRepo();
        public void Run()
        {
            SeedContent();
            RunMenu();
        }
        public void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Hello! Welcome to your Koomodo Insurance app! \n" +
                "Enter the number of the option you would like to select. \n" +
                "1. Show list of Developers \n" +
                "2. Create a new Developer Team \n" +
                "3. Show list of Developer Teams \n" +
                "4. Add a developer to a Developer Team \n" +
                "5. Remove a developer from a Developer Team \n" +
                "6. Delete a Developer Team \n" +
                "7. Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                { 
                    case "1":
                        //show list of developers
                        DisplayListOfDevelopers();
                        break;

                    case "2":
                        //create dev team
                        CreateNewDevTeam();
                        break;

                    case "3":
                        //show teams
                        ShowAllDevTeams();
                        break;

                    case "4":
                        //add members
                        AddMembersToDevTeam();
                        break;

                    case "5":
                        //remove members
                        RemoveMemberFromDevTeam();
                        break;

                    case "6":
                        //remove devTeam
                        DeleteDevTeam();
                        break;

                    case "7":
                        //exit
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter in a valid number between 1 and 7. \n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }

        }

        
        private void DisplayListOfDevelopers()
        {
           
            //show list
           
            List<Developer> listOfDevelopers = _developerDirectory.GetAllDevelopers();
            foreach (Developer developer in listOfDevelopers)
            {
                Console.WriteLine($"developerName: {developer.DeveloperName}");
                Console.WriteLine($"developerID: {developer.DeveloperID}");
                Console.WriteLine($"acessToPluralSight: {developer.AccessToPluralsight}");
            }
            Console.ReadKey();
                
        }
        
        private void GetAllDevelopers(Developer personInfo)
        {
          

        }
    

        private void CreateNewDevTeam()
        {
            bool createNewTeam = true;
            while (createNewTeam)
            { 
                //TeamName
                Console.WriteLine("You have chosen to create a new Developer Team. \n" +
                    "Let's start by giving the Developer Team a name. \n" +
                    "Please assign a Team Name and press enter to continue...");
                
                
                DevTeam addDevTeam = new DevTeam();
                addDevTeam.TeamName = Console.ReadLine();

               

                //TeamID
                Console.WriteLine("Now that you have made a Team Name, you will need to give the Team a Team ID Number. \n" +
                   "Please assign a Team ID Number and press enter to continue... ");

                addDevTeam.TeamID = int.Parse(Console.ReadLine());
               

                Console.ReadKey();

                break;
            }

        
        }


        private void ShowAllDevTeams()
        {
            DevTeam teams = new DevTeam();
            _devTeam.CreateDevTeam(teams);
            GetAllDevTeams(teams);
            Console.ReadKey();
        }
        private void GetAllDevTeams(DevTeam info)
        {
            Console.WriteLine($"teamName: {info.TeamName}");
            Console.WriteLine($"teamID: {info.TeamID}");
            Console.WriteLine($"teamMembers: {info.TeamMembers}");
        }
        private void AddMembersToDevTeam()
        {
            bool addMembers = true;
            while (addMembers)
            {
                Console.WriteLine("You have chosen to add members to a Developer Team. \n" +
                    "Below is a list of the teams that you can add members to. \n" +
                    "Please type the name of the team that you would like to add members to and press enter to continue...");
                
                string teamOption = Console.ReadLine();
                
                DevTeam teamAddMember = _devTeam.GetDevTeamByTeamName(teamOption);

                DisplayListOfDevelopers();

                Console.WriteLine("What is the ID of the developer that you want to add?");
                
                string developerAdd = Console.ReadLine();

                Developer personAdd = _developerDirectory.GetDeveloperByID(int.Parse(developerAdd));

                teamAddMember.TeamMembers.Add(personAdd);
            }
        }
        private void RemoveMemberFromDevTeam()
        {
            bool removeMembers = true;
            while (removeMembers)
            {
                Console.WriteLine("You have chosen to remove members from a Developer Team. \n" +
                    "Below is a list of the teams that you can remove members from. \n" +
                    "Please type the name of the team that you would like to remove members from and press enter to continue...");

                string teamOption2 = Console.ReadLine();

                DevTeam teamRemoveMember = _devTeam.GetDevTeamByTeamName(teamOption2);

                ShowAllDevTeams();

                Console.WriteLine("What is the ID of the developer that you want to remove?");

                string developerRemove = Console.ReadLine();

                Developer personRemove = _developerDirectory.GetDeveloperByID(int.Parse(developerRemove));

                teamRemoveMember.TeamMembers.Remove(personRemove);

            }
        }
        
        private void DeleteDevTeam()
        {
            Console.WriteLine("You have chosen to delete a Developer Team. \n" +
                "Below is a list of the Developer Teams that you can delete. \n" +
                "Please type the team name that you would like to delete and press enter to continue...");

            string teamDelete = Console.ReadLine();

            DevTeam teamRemove = _devTeam.GetDevTeamByTeamName(teamDelete);

            ShowAllDevTeams();

            Console.WriteLine("What is the id of the team that you want to remove?");

            string removeTeam = Console.ReadLine();

            DevTeam deleteTeam = _devTeam.GetDevTeamByID(int.Parse(teamDelete));

            //teamRemove.TeamName.Remove(deleteTeam);



        }

        private void SeedContent()
        {
            Developer developer1 = new Developer(1, "George", "yes");
            Developer developer2 = new Developer(2, "Hank", "no");
            Developer developer3 = new Developer(3, "Fred", "yes");
            Developer developer4 = new Developer(4, "Todd", "yes");
            Developer developer5 = new Developer(5, "Bruce", "no");
            Developer developer6 = new Developer(6, "Shane", "yes");


            _developerDirectory.AddDeveloperToDirectory(developer1);
            _developerDirectory.AddDeveloperToDirectory(developer2);
            _developerDirectory.AddDeveloperToDirectory(developer3);
            _developerDirectory.AddDeveloperToDirectory(developer4);
            _developerDirectory.AddDeveloperToDirectory(developer5);
            _developerDirectory.AddDeveloperToDirectory(developer6);
        }
    }
}

