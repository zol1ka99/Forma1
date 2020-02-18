using Forma1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Controller
{
    class F1controller
    {
        TeamService teamService;

        public F1controller()
        {
            teamService = new TeamService();

        }
    }
}
