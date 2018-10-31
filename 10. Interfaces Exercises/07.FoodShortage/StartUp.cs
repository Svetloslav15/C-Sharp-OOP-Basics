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
            int lines = int.Parse(Console.ReadLine());
            List<Creature> buyers = new List<Creature>();
            for (int i = 0; i < lines; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                if (tokens.Length == 4)
                {
                    buyers.Add(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]));
                }
                else if (tokens.Length == 3)
                {
                    buyers.Add(new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]));
                }
            }
            string input = Console.ReadLine();
            while (input != "End")
            {
                var person = buyers.FirstOrDefault(x => x.Name == input);
                int index = buyers.IndexOf(person);
                if (index != -1)
                {
                    buyers[index].BuyFood();
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(buyers.Select(x => x.Food).Sum());
        }
    }
}