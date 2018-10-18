using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Pokemon
    {
        private string name;
        private string type;

        public Pokemon(string name, string type)
        {
            this.name = name;
            this.type = type;
        }
        public override string ToString()
        {
            return $"{this.name} {this.type}";
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
