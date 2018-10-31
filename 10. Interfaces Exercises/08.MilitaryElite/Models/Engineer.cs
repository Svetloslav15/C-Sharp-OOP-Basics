using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses.Models
{
    public class Engineer : SpecialisedSoldier
    {
        public List<Repair> Repairs { get; set; }
        public Engineer(string id, string firstname, string lastname, decimal salary, string corp, List<Repair> repairs) 
            : base(id, firstname, lastname, salary, corp)
        {
            this.Repairs = repairs;
        }
        public override string ToString()
        {
            var result = base.ToString() + $"\nCorps: {this.Corp}\n" + "Repairs:";

            foreach (var r in Repairs)
            {
                result += $"\n  {r}";
            }
            return result;
        }
    }
}
