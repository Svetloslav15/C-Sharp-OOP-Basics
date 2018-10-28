using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public decimal WeekSalary
        {
            get => this.weekSalary;
            set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }
        public decimal WorkingHours
        {
            get => this.workHoursPerDay;
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workHoursPerDay = value;
            }
        }

        public Worker(string firstName, string lastName, decimal salary, decimal hours) : base(firstName, lastName)
        {
            this.WeekSalary = salary;
            this.WorkingHours = hours;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"Week Salary: {this.WeekSalary:F2}\n" +
                $"Hours per day: {this.workHoursPerDay:f2}\n" +
                $"Salary per hour: {this.weekSalary / 5 / this.workHoursPerDay:f2}";
        }
    }
}
