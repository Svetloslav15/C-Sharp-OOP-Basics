using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Repair : IRepair
    {
        public string PartName { get; set; }
        public int HoursWorkded { get; set; }

        public Repair(string partName, int hoursWorkded)
        {
            this.PartName = partName;
            this.HoursWorkded = hoursWorkded;
        }
    }
}