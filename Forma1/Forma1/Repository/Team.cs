using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Forma1.Model;

namespace Forma1.Repository
{
    /// <summary>
    /// Forma 1 ben szereplő csapat.
    /// </summary>
    class Team
    {
        /// <summary>
        /// A csapat neve
        /// </summary>
        private string name;
        /// <summary>
        /// Csapat versenyzői
        /// </summary>
        List<Racer> racers;
        /// <summary>
        /// A csapat csak névvel jöhet létre
        /// </summary>
        /// <param name="name">Csapat neve</param>
        public Team(string name)
        {
            this.name = name;
            racers = new List<Racer>();
        }
    }
}
