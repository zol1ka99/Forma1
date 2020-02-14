using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{
    /// <summary>
    /// Az F1 nyilvántartó osztálya
    /// </summary>
    class F1
    {
        /// <summary>
        /// Az F1 csapatok
        /// </summary>
        List<Team> teams;

        public F1()
        {
            teams = new List<Team>();
        }

        /// <summary>
        /// Létrehoz egy új csapatot az F1-ben
        /// </summary>
        /// <param name="name">Új csapat neve</param>
        public void add(string name)
        {
            Team t = new Team(name);
            teams.Add(t);
        }
    }
}
