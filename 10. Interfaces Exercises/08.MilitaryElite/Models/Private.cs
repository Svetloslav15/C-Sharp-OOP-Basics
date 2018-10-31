using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses.Models
{
    public class Private : Soldier
    {
        public decimal Salary { get; private set; }
        public Private(string firstname, string lastname, string id, decimal salary)
            : base(firstname, lastname, id)
        {
            this.Salary = salary;
        }
        public override string ToString()
        {
            return base.ToString() + $" Salary: {this.Salary:f2}";
        }
    }
}
