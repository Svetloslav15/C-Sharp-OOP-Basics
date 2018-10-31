using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public abstract class Creature : IBuyer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Food { get; set; }

        public Creature(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public abstract void BuyFood();
    }
}
