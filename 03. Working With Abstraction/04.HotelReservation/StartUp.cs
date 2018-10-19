using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(" ");
            decimal price = decimal.Parse(tokens[0]);
            int days = int.Parse(tokens[1]);
            string season = tokens[2];
            string discount = "None";
            if (tokens.Length > 3)
            {
                discount = tokens[3];
            }
            int seasonNum = 0;
            int discountNum = 0;
            switch (season)
            {
                case "Autumn":seasonNum = 1;break;
                case "Spring":seasonNum = 2;break;
                case "Winter":seasonNum = 3;break;
                case "Summer":seasonNum = 4;break;
                default:
                    break;
            }
            switch (discount)
            {
                case "None": discountNum = 0; break;
                case "SecondVisit": discountNum = 10; break;
                case "VIP": discountNum = 20; break;
                default:
                    break;
            }
            Console.WriteLine("{0:f2}",Calculator.Calculate(price, days, seasonNum, discountNum));
        }
    }
}
