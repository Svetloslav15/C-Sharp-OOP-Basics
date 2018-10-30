using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public abstract class Creature
    {
        public string Name { get; set; }
        public string Birthday { get; set; }

        public Creature(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }
    }
}
