using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Model
{
    /// <summary>
    /// A versenyző osztály
    /// </summary>
    class Racer
    {
        private string name;
        private int age;
        private int salery;
        
        /// <summary>
        /// Üres konstruktor lehetetlen adatokkal.
        /// </summary>
        public Racer()
        {
            name = string.Empty;
            age = -1;
            salery = -1;
        }

        /// <summary>
        /// Teljes konstruktor
        /// </summary>
        /// <param name="name">Versenyző neve</param>
        /// <param name="age">Versenyző életkora</param>
        /// <param name="salery">Versenyző fizetése</param>
        public Racer(string name, int age, int salery)
        {
            this.name = name;
            this.age = age;
            this.salery = salery;
        }

        /// <summary>
        /// Versenyző nevének megadása
        /// </summary>
        /// <param name="name">A versenyző neve</param>
        public void setName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Versenyző korának megadása
        /// </summary>
        /// <param name="age">A versenyző kora</param>
        public void setAge(int age)
        {
            this.age = age;
        }

        /// <summary>
        /// Versenyző fizetésének megadása
        /// </summary>
        /// <param name="salery">A versenyző fizetése</param>
        public void setSalery(int salery)
        {
            this.salery = salery;
        }

        /// <summary>
        /// Versenyző nevét adja vissza
        /// </summary>
        /// <returns>A versenyző neve</returns>
        public string getName()
        {
            return name;
        }

        /// <summary>
        /// Versenyző életkorát adja vissza
        /// </summary>
        /// <returns>A versenyző életkorát</returns>
        public int getAge()
        {
            return age;
        }

        /// <summary>
        /// Versenyző fizetését adja vissza
        /// </summary>
        /// <returns>A versenyző fizetését</returns>
        public int getSalery()
        {
            return salery;
        }
    }
}
