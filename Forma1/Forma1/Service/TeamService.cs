using Forma1.myexception;
using Forma1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Service
{

    /// <summary>
    /// Service réteg feladata az üzleti logika megvalósítása
    /// Kapcsolatot terement a Controller és Repository réteg között
    /// 
    /// </summary>
    class TeamService
    {
        forma1 f1Repository;


        public TeamService()
        {
            f1Repository = new forma1();
        }

        public void addTeam(string teamName)
        {
            try
            {
                Team t = new Team(teamName);
                f1Repository.add(t);
            }
            catch (F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
        }
    }
}
