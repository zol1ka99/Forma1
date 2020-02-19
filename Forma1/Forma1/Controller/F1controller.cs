﻿using Forma1.myexception;
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
    /// Controller réget kapcsolatot teremtn a GUI és a Service réteg között
    /// Feladata a bemenő adatok vizsgálata
    /// Feladata a megjelenítendő adatok átalakítása GUI számára
    /// Feladata a programozónak szánt hibaüzenetek megjelenítése
    /// </summary>

    class F1controller
    {
        TeamService teamService;

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
