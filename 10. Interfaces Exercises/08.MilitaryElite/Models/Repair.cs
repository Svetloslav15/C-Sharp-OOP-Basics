using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses.Models
{
    public class Repair
    {
        public string PartName { get; set; }
        public int WorkHours { get; set; }

        public Repair(string partName, int hours)
        {
            this.PartName = partName;
            this.WorkHours = hours;
        }
        public override string ToString()
        {
            return $"Part Name: {PartName} Hours Worked: {WorkHours}";
        }
    }
}
