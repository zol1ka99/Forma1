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
        /// <summary>
        /// A versenyző osztály adattagjai
        /// </summary>
        private string name;
        private int age;
        private int salary;

        /// <summary>
        /// Üres konstruktor lehetetlen adatokkal
        /// </summary>
        public Racer()
        {
            name = String.Empty;
            age = -1;
            salary = -1;
        }
        /// <summary>
        /// Teljes konstruktor
        /// </summary>
        /// <param name="name">Versenyző neve</param>
        /// <param name="age">Versenyző életkora</param>
        /// <param name="salary">Versenyző fizetése</param>
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
        /// A versenyző életkorának megadása
        /// </summary>
        /// <param name="age">A versenyző életkora</param>
        public void setAge(int age)
        {
            this.age = age;
        }
        /// <summary>
        /// A versenyző fizetésénének megadása
        /// </summary>
        /// <param name="salary">A versenyző fizetése</param>
        public void setSalary(int salary)
        {
            this.salary = salary;
        }
        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }
        public int getSalary()
        {
            return salary;
        }
    }
}
