using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1projekt.Modell
{
    /// <summary>
    /// A versenyző osztály
    /// </summary>
    class Racer
    {
        /// <summary>
        /// A versenyző osztály adattagjai
        /// </summary>
        private string name;
        private int age;
        private int salary;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public Racer()
        {
            name = string.Empty;
            age = -1;
            salary = -1;
        }

        /// <summary>
        /// Teljes konstruktor
        /// </summary>
        /// <param name="name">A versenyző neve</param>
        /// <param name="age">A versenyző kora</param>
        /// <param name="salary">A versenyző bére</param>
        public Racer(string name, int age, int salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
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
        /// Versenyző kora megadása
        /// </summary>
        /// <param name="age">A versenyző kora</param>
        public void setAge(int age)
        {
            this.age = age;
        }
        /// <summary>
        /// Versenyző fizetése megadása
        /// </summary>
        /// <param name="salary">A versenyző fizetése</param>
        public void setSalary(int salary)
        {
            this.salary = salary;
        }

        /// <summary>
        /// A versenyző nevét adja vissza
        /// </summary>
        /// <returns> Versenyző neve </returns>
        public string getName()
        {
            return name;    
        }

        /// <summary>
        /// A versenyző korát adja vissza
        /// </summary>
        /// <returns> Versenyző kora </returns>
        public int getAge()
        {
            return age;
        }

        /// <summary>
        /// A versenyző fizetését adja vissza
        /// </summary>
        /// <returns> Versenyző fizetése </returns>
        public int getSalary()
        {
            return salary;
        }
    }
}
