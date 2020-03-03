using Forma1projekt.Exceptionmy;
using Forma1projekt.Modell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1projekt.Repository
{
    /// <summary>
    /// A Forma1-ben szereplő csapatok
    /// </summary>
    class Team
    {
        /// <summary>
        /// Csapat neve
        /// </summary>
        private string name;

        /// <summary>
        /// Csapat versenyzői
        /// </summary>
        List<Racer> racers;

        /// <summary>
        /// A cspat nével jöhet létre
        /// </summary>
        /// <param name="csapat neve"></param>
        public Team(string name)
        {
            this.name = name;
            racers = new List<Racer>();
        }

        /// <summary>
        /// Visszaadja a Csapat nevét
        /// </summary>
        /// <returns></returns>
        public string getTeamName()
        {
            return name;
        }

        /// <summary>
        /// A csapat versenyzőinek száma
        /// </summary>
        /// <returns>A csapat számát adja vissza</returns>
        public int getNumberOfRacers()
        {
            if (racers == null)
            {
                throw new TeamException("Végzetes hiba, a racer lista nincs példányosítva!");
            }
            else
            {
                return racers.Count;
            }
            
        }

        public void update(string newTeamName)
        {
            name = newTeamName;
        }
    }
}
