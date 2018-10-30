using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Citizen : IIdentifiable
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public Citizen(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }
    }
}
