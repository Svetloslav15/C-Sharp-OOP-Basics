using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Team
    {
        private string name;
        private int raiting;

        public int Raiting
        {
            get
            {
                if (this.players.Count > 0)
                {
                    this.CalculateRating();
                }
                return raiting;
            }
        }

        private List<Player> players;

        public List<Player> Players
        {
            get { return players; }
            set { players = value; }
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (value.Trim() == "")
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }
        public void CalculateRating()
        {
            this.raiting = (int)Math.Round(this.players.Sum(x => x.SkillLevel()) / this.players.Count);
        }
        public Team(string name)
        {
            this.Name = name;
            this.raiting = 0;
            this.players = new List<Player>();
        }
        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }
        public void RemovePlayer(string name)
        {
            var player = this.players.FirstOrDefault(x => x.Name == name);
            if (player == null)
            {
                throw new ArgumentException($"Player {name} is not in {this.name} team.");
            }
            this.players.Remove(player);
        }
    }
}
