using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Citizen : Creature, IIdentifiable, IBuyer
    {
        public string Id { get; set; }
        public string Birtday { get; set; }

        public Citizen(string name, int age, string id, string birthday)
            : base(name, age)
        {
            this.Id = id;
            this.Food = 0;
            this.Birtday = birthday;
        }

        public override void BuyFood()
        {
            this.Food += 10;
        }
    }
}