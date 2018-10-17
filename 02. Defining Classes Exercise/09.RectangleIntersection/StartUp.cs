using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] counts = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<Rectangle> rects = new List<Rectangle>();
            for (int i = 0; i < counts[0]; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                Rectangle rect = new Rectangle(tokens[0], double.Parse(tokens[1]), double.Parse(tokens[2]), double.Parse(tokens[3]), double.Parse(tokens[4]));
                rects.Add(rect);
            }
            for (int i = 0; i < counts[1]; i++)
            {
                string[] ids = Console.ReadLine().Split();
                var first = rects.First(x => x.id == ids[0]);
                var second = rects.First(x => x.id == ids[1]);
                Console.WriteLine(first.Intersect(second));
            }
        }
    }
}
