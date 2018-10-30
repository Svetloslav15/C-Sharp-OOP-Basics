using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Creature> creatures = new List<Creature>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split();
                if (tokens[0] == "Citizen")
                {
                    creatures.Add(new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]));
                }
                else if (tokens[0] == "Pet")
                {
                    creatures.Add(new Pet(tokens[1], tokens[2]));
                }
                input = Console.ReadLine();
            }
            int year = int.Parse(Console.ReadLine());
            creatures.Where(x => x.Birthday.Split('/', StringSplitOptions.RemoveEmptyEntries)[2] == year.ToString())
                .Select(x => x.Birthday)
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }
}