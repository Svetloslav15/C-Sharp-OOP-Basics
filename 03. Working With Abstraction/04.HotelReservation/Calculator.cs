using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public static class Calculator
    {
        public static decimal Calculate(decimal pricePerDay, int days, int seasonNum, int discount)
        {
            decimal num = (decimal)pricePerDay * days * seasonNum;
            return num -  (decimal)discount / 100 * num;
        }
    }
}