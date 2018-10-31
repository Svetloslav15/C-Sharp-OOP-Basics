using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses.Models
{
    public class Commando : SpecialisedSoldier
    {
        public List<Mission> Missions { get; set; }

        public Commando(string id, string firstname, string lastname, decimal salary, string corp, List<Mission> missions)
            : base(id, firstname, lastname, salary, corp)
        {
            this.Missions = missions;
        }
        public override string ToString()
        {
            var result = base.ToString() + $"\nCorps: {this.Corp}" + "\nMissions:";
            foreach (var m in Missions)
            {
                result += $"\n  {m}";
            }
            return result;
        }
    }
}
