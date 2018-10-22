using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            decimal length = decimal.Parse(Console.ReadLine());
            decimal width = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());
            Box box;
            try
            {
                box = new Box(length, width, height);
            }
            catch (ArgumentException arg)
            {
                Console.WriteLine(arg.Message);
                return;
            }

            Console.WriteLine($"Surface Area - {box.Surface():f2}");
            Console.WriteLine($"Lateral Surface Area - {box.LateralSurface():f2}");
            Console.WriteLine($"Volume - {box.Volume():f2}");
        }
    }
}
