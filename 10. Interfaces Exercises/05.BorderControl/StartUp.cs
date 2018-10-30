using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> items = new List<IIdentifiable>();
            List<Robot> robots = new List<Robot>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] tokens = input.Split();
                if (tokens.Length == 2)
                {
                    items.Add(new Robot(tokens[0], tokens[1]));
                }
                else
                {
                    items.Add(new Citizen(tokens[0], tokens[2], int.Parse(tokens[1])));
                }
                input = Console.ReadLine();
            }
            string fake = Console.ReadLine();
            foreach (var item in items)
            {
                if (item.Id.EndsWith(fake))
                {
                    Console.WriteLine(item.Id);
                }
            }
        }
    }
}
