using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        public string FirstName
        {
            get { return firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { this.lastName = value; }
        }
        public int Age
        {
            get { return age; }
            set { this.age = value; }
        }
        public Person(string firstname, string lastname, int age)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.age = age;
        }
        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} is {this.age} years old.";
        }
    }
}
