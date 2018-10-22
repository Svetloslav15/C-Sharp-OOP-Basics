using System;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main()
        {
            decimal length = decimal.Parse(Console.ReadLine());
            decimal width = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());
            Box box = new Box(length, width, height);

            Console.WriteLine($"Surface Area - {box.Surface():f2}");
            Console.WriteLine($"Lateral Surface Area - {box.LateralSurface():f2}");
            Console.WriteLine($"Volume - {box.Volume():f2}");
        }
    }
}
