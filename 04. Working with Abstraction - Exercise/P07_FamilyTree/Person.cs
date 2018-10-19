using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bithdate { get; set; }
        public List<Person> Parents { get; set; }
        public List<Person> Children { get; set; }

        public Person()
        {
            this.Children = new List<Person>();
            this.Parents = new List<Person>();
        }

        public Person(string firstName, string lastName)
            : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Person(string birthdate)
            : this()
        {
            this.Bithdate = birthdate;
        }

        public void AddChild(Person child)
        {
            this.Children.Add(child);
        }

        public void AddParent(Person parent)
        {
            this.Parents.Add(parent);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"{FirstName} {LastName} {Bithdate}");
            builder.AppendLine("Parents:");

            foreach (var parent in Parents)
            {
                builder.AppendLine($"{parent.FirstName} {parent.LastName} {parent.Bithdate}");
            }

            builder.AppendLine("Children:");

            foreach (var child in Children)
            {
                builder.AppendLine($"{child.FirstName} {child.LastName} {child.Bithdate}");
            }

            return builder.ToString();
        }
    }
}