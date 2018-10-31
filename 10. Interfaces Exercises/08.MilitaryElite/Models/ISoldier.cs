using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public interface ISoldier
    {
        string Firstname { get; set; }
        string Lastname { get; set; }
        string Id { get; set; }
    }
}
