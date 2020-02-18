using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{
    /// <summary>
    /// A forma egy nyilvántartó osztály
    /// Szolgáltatást nyújt a Service rétegnek
    /// </summary>
    class forma1
    {
        /// <summary>
        /// forma 1 csapatok
        /// </summary>
        List<Team> teams;
        public forma1()
        {
            teams = new List<Team>();
        }
        /// <summary>
        /// Létrehoz egy új csapatot név alapján
        /// </summary>
        /// <param name="name">Az csapat neve</param>
        public void add(string name)
        { 
            Team team = new Team(name);
            teams.Add(team);
        }
    }
}
