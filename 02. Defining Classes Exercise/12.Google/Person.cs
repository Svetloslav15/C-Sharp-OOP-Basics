using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private Company company;
        private Car car;
        private List<Parent> parents;
        private List<Child> children;
        private List<Pokemon> pokemons;

        public Person()
        {
            Company company = new Company();
            Car car = new Car();
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
            this.Pokemons = new List<Pokemon>();
        }
        public Person(string name)
            : this()
        {
            this.Name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Company Company
        {
            get { return company; }
            set { company = value; }
        }

        public Car Car
        {
            get { return car; }
            set { car = value; }
        }

        public List<Parent> Parents
        {
            get { return parents; }
            set { parents = value; }
        }

        public List<Child> Children
        {
            get { return children; }
            set { children = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }

        public void AddCompany(Company company)
        {
            this.company = company;
        }
        public void AddPokemon(Pokemon pokemon)
        {
            this.pokemons.Add(pokemon);
        }
        public void AddCar(Car car)
        {
            this.car = car;
        }
        public void AddParent(Parent parent)
        {
            this.parents.Add(parent);
        }
        public void AddChild(Child child)
        {
            this.children.Add(child);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(this.Name);
            sb.AppendLine($"Company:");
            if (this.Company != null)
            {
                sb.AppendLine($"{this.company}");
            }
            sb.AppendLine($"Car:");
            if (this.Car != null)
            {
                sb.AppendLine($"{this.car}");
            }
            sb.AppendLine($"Pokemon:");
            foreach (var poke in this.Pokemons)
            {
                sb.AppendLine($"{poke}");
            }
            sb.AppendLine($"Parents:");
            foreach (var p in this.Parents)
            {
                sb.AppendLine($"{p}");
            }
            sb.AppendLine($"Children:");
            foreach (var c in this.Children)
            {
                sb.AppendLine($"{c}");
            }
            return sb.ToString();
        }
    }
}
