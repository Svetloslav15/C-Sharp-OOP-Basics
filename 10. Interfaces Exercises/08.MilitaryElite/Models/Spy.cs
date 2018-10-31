using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses.Models
{
    public class Spy : Soldier
    {
        public int CodeNum { get; set; }
        public Spy(string firstname, string lastname, string id, int code) : base(firstname, lastname, id)
        {
            this.CodeNum = code;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nCode Number: {this.CodeNum}";
        }
    }
}
