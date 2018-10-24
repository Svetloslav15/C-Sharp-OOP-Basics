using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Player
    {
        private string[] statNames = new string[] { "Endurance", "Sprint", "Dribble", "Passing", "Shooting" };
        private string name;

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
        private int[] stats;

        public int[] Stats
        {
            get { return stats; }
            set
            {
                this.stats = new int[5];
                for (int index = 0; index < value.Length; index++)
                {
                    if (value[index] < 1 || value[index] > 100)
                    {
                        throw new ArgumentException($"{this.statNames[index]} should be between 0 and 100.");
                    }
                    this.stats[index] = value[index];
                }
            }
        }

        public Player(string name, int[] stats)
        {
            Name = name;
            Stats = stats;
        }

        public double SkillLevel()
        {
            return this.stats.Average();
        }
    }
}
