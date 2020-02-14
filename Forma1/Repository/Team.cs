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
    }
}
