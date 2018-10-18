using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string birthday;
        private List<Person> parents;
        private List<Person> children;

        public Person()
        {
            this.parents = new List<Person>();
            this.children = new List<Person>();
        }
        public Person(string firstname, string lastname) : this()
        {
            this.firstName = firstname;
            this.lastName = lastname;
        }
        public Person(string birthday) : this()
        {
            this.birthday = birthday;
        }
        public Person(string firstName, string lastname, string birthday) : this()
        {
            this.firstName = firstName;
            this.lastName = lastname;
            this.birthday = birthday;
        }

        public string FirstName
        {
            get { return this.firstName; }
        }
        public string Lastname
        {
            get { return this.lastName; }
        }
        public string Birthday
        {
            get { return this.birthday; }
        }

        public void AddParent(Person parent)
        {
            this.parents.Add(parent);
        }

        public void AddChild(Person child)
        {
            this.children.Add(child);
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} {this.birthday}\n" +
                $"Parents:\n" +
                $"{string.Join(Environment.NewLine, this.parents)}" +
                $"Children:\n" +
                $"{string.Join(Environment.NewLine, this.children)}";
        }
    }
}
