using DefiningClasses.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses.Models
{
    public class LieutenantGeneral : Private
    {
        public List<Private> Privates { get; }

        public LieutenantGeneral(string firstname, string lastname, string id, decimal salary, List<Private> privates) 
            : base(firstname, lastname, id, salary)
        {
            this.Privates = privates;
        }

        public override string ToString()
        {
            string result = base.ToString() + "\nPrivates:";
            foreach (var p in Privates)
            {
                result += $"\n  {p}";
            }
            return result;
        }
    }
}
