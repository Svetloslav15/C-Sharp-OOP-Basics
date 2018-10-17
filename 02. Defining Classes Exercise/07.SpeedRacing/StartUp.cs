using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> set = new List<Car>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                List<string> tokens = Console.ReadLine()
                    .Split()
                    .ToList();
                string model = tokens[0];
                if (!set.Any(x => x.Model == model))
                {
                    tokens.RemoveAt(0);
                    List<double> tokensSec = tokens.Select(double.Parse).ToList();
                    Car car = new Car(model, tokensSec[0], tokensSec[1]);
                    set.Add(car);
                }
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] tokens = command.Split();
                string model = tokens[1];
                int amountKm = int.Parse(tokens[2]);
                Car currentCar = set.First(x => x.Model == model);
                currentCar.MoveCar(amountKm);
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(Environment.NewLine, set));
        }
    }
}
