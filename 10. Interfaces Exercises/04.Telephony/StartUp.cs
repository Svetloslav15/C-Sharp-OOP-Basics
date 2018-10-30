using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split()
                .ToList();
            List<string> urls = Console.ReadLine()
                .Split()
                .ToList();
            Smartphone smartphone = new Smartphone();
            foreach (var item in numbers)
            {
                try
                {
                    smartphone.Calling(item);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            foreach (var item in urls)
            {
                try
                {
                    smartphone.Brows(item);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
