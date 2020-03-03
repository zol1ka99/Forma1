using Forma1projekt.Exceptionmy;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1projekt.Repository
{
    /// <summary>
    /// A F1 nyilvántartó osztály, összes csapat a F1-be
    /// Szolgáltatást nyújt a service rétegnek
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
        /// A Teamet hozzáadja a csapatok listájához
        /// </summary>
        /// <param name="A cspat listájához hozzáadott csapat"></param>
        public void add(Team t)
        {
            if (teams == null)
                throw new F1Exception("Végzetes hiba a team nincs példányosítva.");
            else
                teams.Add(t);
        }

        public List<Team> getTeams()
        {
            if (teams == null)
            {
                throw new F1Exception("Végzetes hiba a team nincs példányosítva.");
            }  
            else
            {
                return teams;
            }
        }

        /// <summary>
        /// Ellenőrzi, hogy a csapat neve létezik e már a listába
        /// </summary>
        /// <param name="teamName">Keresett csapat név</param>
        /// <returns> true = ha létezik, false = ha nem létezik</returns>
        public bool IsExsist(string teamName)
        {
            if (teams == null)
            {
                throw new F1Exception("Végzetes hiba a team nincs példányosítva.");
            }
            else
            {
                foreach (Team t in teams)
                {
                    if (t.getTeamName() == teamName)
                    {
                        return true;
                    }  
                }
                return false;
            }
        }

        /// <summary>
        /// Csapat versenyzőinek száma
        /// </summary>
        /// <param name="teamName">A csapat neve</param>
        /// <returns>Vissza versenyzőinek számát</returns>
        public int getNumberOfRacers(string teamName)
        {
            if (teams == null)
            {
                throw new F1Exception("Nincs ilyen lista.");
            }
            else
            {
                foreach (Team t in teams)
                {
                    if (t.getTeamName() == teamName)
                    {
                        try
                        {
                            return t.getNumberOfRacers();
                        }
                        catch (TeamException te)
                        {
                            Debug.WriteLine(te.Message);
                            throw new F1Exception(teamName+ " csapatot nem lehet törölni!");
                        }
                       
                    }
                }
                throw new F1Exception(teamName+" csapat név nem létezik!!!!!!!!!!!!!");
            }
        }

        /// <summary>
        /// Adott nevű team törlése (van itt bug)
        /// </summary>
        /// <param name="teamNameToDelete"> Csapat név</param>
        public void delete(string teamNameToDelete)
        {
            if (teams == null)
            {
                throw new F1Exception("");
            }
            else
            {
                foreach (Team t in teams)
                {
                    int index = 0;
                    if (t.getTeamName() == teamNameToDelete)
                    {
                        teams.RemoveAt(index);
                    }
                    index++;
                }
                throw new F1Exception(teamNameToDelete + " csapat nem létezik, nem lehet törölni.");
                
            }
        }
        /// <summary>
        /// Létrehoz eg csapatoto egy név alapján
        /// </summary>
        /// <param name="Csapat név"></param>
        public void Add( string name)
        {
            if (teams == null)
                throw new F1Exception("Végzetes hiba a team nincs példányosítva.");
            else
            {
                Team t = new Team(name);
                teams.Add(t);
            }
            
        }
    }
}
