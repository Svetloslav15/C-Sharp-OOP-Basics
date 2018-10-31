using ExplicitInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    public class Citizen : IPerson, IResidental
    {
        public string Name { get; set; }

        public string Country { get; set; }

        public int Age { get; set; }

        string IPerson.GetName()
        {
            return this.Name;
        }

        string IResidental.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }
        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }
    }
}
