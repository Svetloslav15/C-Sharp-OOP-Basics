using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Rebel : Creature, IBuyer
    {
        public string Group { get; set; }

        public override void BuyFood()
        {
            this.Food += 5;
        }
        public Rebel(string name, int age, string group) : base(name, age)
        {
            this.Group = group;
        }
    }
}
