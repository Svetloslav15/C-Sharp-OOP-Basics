using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DataModifier
    {
        public static int CalculateDifference(string first, string second)
        {
            DateTime firstDate = DateTime.Parse(first);
            DateTime secondDate = DateTime.Parse(second);

            return Math.Abs((firstDate - secondDate).Days);
        } 
    }
}
