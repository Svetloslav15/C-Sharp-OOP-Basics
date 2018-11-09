using System;
using System.Collections.Generic;
using System.Text;

namespace GrandPrix.Models.Tyres
{
    public class HardTyre : Tyre
    {
        public HardTyre(double hardness) 
            : base("Hard", hardness)
        {
        }
    }
}