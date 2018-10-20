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
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

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
        public Person(string firstname, string lastname, int age, decimal salary)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.age = age;
            this.salary = salary;
        }
        public void IncreaseSalary(decimal bonusPercentage)
        {
            if (this.age >= 30)
            {
                this.salary += bonusPercentage / 100 * this.salary;
            }
            else
            {
                this.salary += bonusPercentage / 100 * this.salary / 2;
            }
        }
        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} receives {this.salary:f2} leva.";
        }
    }
}