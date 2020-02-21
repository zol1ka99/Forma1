using Forma1.myexception;
using Forma1.Repository;
using Forma1.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Controller
{
    /// <summary>
    /// Controller réteg kapcsolatot teremt a GUI és a Service réteg között
    /// Feladata a bemenő adatok vizsgálata
    /// Feladata a megjelenítendő adatok átalakítása GUI számára
    /// Feladata a programozónak szánt hibaüzenetek megjelenítése
    /// </summary>

    class F1controller
    {
        TeamService teamService;

        public List <string> getTeamNames()
        {
            try
            {
                List<Team> teams = teamService.getTeams();
                return TeamListToTeamNameList(teams);
            }
            catch (TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
            }
        }

        public F1controller()
        {
            teamService = new TeamService();

        }

        public void addteamToF1(string teamName)
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
    }
}
