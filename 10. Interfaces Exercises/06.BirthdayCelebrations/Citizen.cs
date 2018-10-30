using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Citizen : Creature, IIdentifiable
    {
        public string Id { get; set; }
        public int Age { get; set; }

        public Citizen(string name, int age, string id, string birthday)
            : base(name, birthday)
        {
            this.Id = id;
            this.Age = age;
        }
    }
}