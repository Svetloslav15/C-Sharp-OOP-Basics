using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public List<Person> ReserveTeam
        {
            get { return  reserveTeam; }
        }

        public List<Person> FirstTeam
        {
            get { return firstTeam; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Team(string name)
        {
            this.Name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }
        public void AddPlayer(Person person)
        {
            if (person.Age >= 40)
            {
                this.reserveTeam.Add(person);
            }
            else
            {
                this.firstTeam.Add(person);
            }
        }
        public override string ToString()
        {
             return $"First team has {this.firstTeam.Count} players.\nReserve team has {this.reserveTeam.Count} players.";
        }
    }
}
