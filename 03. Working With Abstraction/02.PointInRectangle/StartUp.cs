using System;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main()
        {
            int[] cords = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Point topLeft = new Point(cords[0], cords[1]);
            Point bottomRight = new Point(cords[2], cords[3]);
            Rectangle rect = new Rectangle(topLeft, bottomRight);

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                cords = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                Point point = new Point(cords[0], cords[1]);
                string result = rect.Contains(point) ? "True" : "False";
                Console.WriteLine(result);
            }
        }
    }
}