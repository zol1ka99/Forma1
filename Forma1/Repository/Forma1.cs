using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1projekt.Repository
{
    /// <summary>
    /// A F1 nyilvántartó osztály, összes csapat a F1-be
    /// </summary>
    class Forma1
    {
        /// <summary>
        /// F1 csapatok ezt tárolja
        /// </summary>
        List<Team> teams;

        public  Forma1()
        {
            teams = new List<Team>();
        }

        /// <summary>
        /// Létrehoz eg csapatoto egy név alapján
        /// </summary>
        /// <param name="Csapat név"></param>
        public void Add( string name)
        {
            Team t = new Team(name);
            teams.Add(t);
        }
    }
}
