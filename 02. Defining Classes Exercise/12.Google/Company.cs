using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Company
    {
        private string name;
        private string department;
        private decimal salary;

        public Company(string name, string department, decimal salary)
        {
            this.name = name;
            this.department = department;
            this.salary = salary;
        }
        public string Name
        {
            get { return this.name; }
        }
        public Company()
        {

        }
        public override string ToString()
        {
            return $"{this.name} {this.department} {this.salary}";
        }
    }
}
