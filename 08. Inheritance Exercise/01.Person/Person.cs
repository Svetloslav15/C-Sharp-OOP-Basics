using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;

        public virtual string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }
                name = value;
            }
        }

        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public virtual int Age
        {
            get => this.age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                this.age = value;
            }
        }
        public override string ToString()
        {
            return $"Name: {this.name}, Age: {this.age}";
        }
    }
}
