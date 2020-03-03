using Forma1projekt.Exceptionmy;
using Forma1projekt.Repository;
using Forma1projekt.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1projekt.Controller
{
    class F1Controller
    {
        TeamService teamService;

        public void addTeamToF1(string teamName)
        {
            
            try
            {
                teamService.addTeam(teamName);
            }
            catch (TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
            }
        }

        public List<string> getTeamNames()
        {
            try
            {
                List<Team> teams = teamService.getTeams();
                return TeamListToTeamNameList(teams);
            }
            catch (TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
                List<string> teamNames = new List<string>();
                return teamNames;
            }
        }

        public void deleteTeam(string teamNameToDelete)
        {
            try
            {
                if (teamService.IsExsist(teamNameToDelete))
                {
                    throw new ControllerException(teamNameToDelete + " csapat nem létezik nem lehet törölni!");
                }
                else 
                {
                    try
                    {
                        teamService.deleteTeam(teamNameToDelete);
                    }
                    catch (TeamServiceException tse)
                    {
                        Debug.WriteLine(tse.Message);
                    }
                    catch (TeamServiceToGUIException tsge)
                    {
                        throw new ControllerException(tsge.Message);
                    }

                }
            }
            catch (TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
            }
        }

        public void modifyTeamName(string oldTeamName, string newTeamName)
        {
            if (teamService.IsExsist())
            {
                throw new ControllerException(newTeamName + " nevű csapat már létezik.");
            }
            else
            {
                teamService.modifyTeamName(oldTeamName, newTeamName);
            }
        }

        private List<string> TeamListToTeamNameList(List<Team> teams)
        {
            List<string> teamNames = new List<string>();
            foreach (Team t in teams)
            {
                teamNames.Add(t.getTeamName());  
            }
            return teamNames;
        }

        /// <summary>
        /// Contorller réteg kapcsolatot teremt a GUI és a Service réteg között
        /// Feladata a bemenő adatok vizssgálata
        /// Feladata a megjelenítendő adatok átalakítása a GUI-ba
        /// Feladata a programozónak szánt hibaüzenetek megjelenítése
        /// </summary>
        public F1Controller()
        {
            teamService = new TeamService();
        }
    }
}
