using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Student : Human
    {
        private string facultyNumber;

        public string FacultyNumber
        {
            get => this.facultyNumber;
            set
            {
                if (value.Length < 5 || value.Length > 10 || !value.All(char.IsLetterOrDigit))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                facultyNumber = value;
            }
        }
        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }
        public override string ToString()
        {
            return base.ToString() +
                $"Faculty number: {this.FacultyNumber}\n";
        }
    }
}
