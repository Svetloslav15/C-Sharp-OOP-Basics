using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public abstract class Animal
    {
        protected string Name { get; set; }
        private int age;
        public int Age
        {
            get => this.age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.age = value;
            }
        }
        private string gender;

        public string Gender
        {
            get { return gender; }
            set
            {
                if (value.ToLower() != "male" && value.ToLower() != "female")
                {
                    throw new ArgumentException("Invalid input!");
                }
                gender = value;
            }
        }

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public virtual void ProduceSound()
        {
            
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}\n" +
                $"{this.Name} {this.Age} {this.Gender}";
        }
    }
}
