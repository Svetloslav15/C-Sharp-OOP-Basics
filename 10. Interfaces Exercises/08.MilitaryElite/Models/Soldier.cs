using MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses.Models
{
    public abstract class Soldier : ISoldier
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Id { get; set; }

        public Soldier(string firstname, string lastname, string id)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Id = id;
        }
        public override string ToString()
        {
            return $"Name: {this.Firstname} {this.Lastname} Id: {this.Id}";
        }
    }
}