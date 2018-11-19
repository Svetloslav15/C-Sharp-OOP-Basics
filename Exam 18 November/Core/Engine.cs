using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalCentre.Core
{
    public class Engine
    {
        private AnimalCentre animalCentre;
        private bool isRunning;

        public Engine()
        {
            this.animalCentre = new AnimalCentre();
            isRunning = true;
        }
        public void Run()
        {
            while (isRunning)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                try
                {
                    switch (command)
                    {
                        case "RegisterAnimal":
                            int energy = int.Parse(tokens[3]);
                            int happiness = int.Parse(tokens[4]);
                            int procedureTime = int.Parse(tokens[5]);
                            Console.WriteLine(this.animalCentre.RegisterAnimal(tokens[1], tokens[2], energy, happiness, procedureTime));
                            break;
                        case "Chip":
                            Console.WriteLine(this.animalCentre.Chip(tokens[1], int.Parse(tokens[2])));
                            break;
                        case "Vaccinate":
                            Console.WriteLine(this.animalCentre.Vaccinate(tokens[1], int.Parse(tokens[2])));
                            break;
                        case "Fitness":
                            Console.WriteLine(this.animalCentre.Fitness(tokens[1], int.Parse(tokens[2])));
                            break;
                        case "Play":
                            Console.WriteLine(this.animalCentre.Play(tokens[1], int.Parse(tokens[2])));
                            break;
                        case "DentalCare":
                            Console.WriteLine(this.animalCentre.DentalCare(tokens[1], int.Parse(tokens[2])));
                            break;
                        case "NailTrim":
                            Console.WriteLine(this.animalCentre.NailTrim(tokens[1], int.Parse(tokens[2])));
                            break;
                        case "Adopt":
                            Console.WriteLine(this.animalCentre.Adopt(tokens[1], tokens[2]));
                            break;
                        case "History":
                            Console.WriteLine(this.animalCentre.History(tokens[1]));
                            break;
                        case "End":
                            this.isRunning = false;
                            DoSth();
                            Environment.Exit(0);
                            break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"InvalidOperationException: {ex.Message}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"ArgumentException: {ex.Message}");
                }
            }
            
        }
        private void DoSth()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.animalCentre.adoptedAnimals.OrderBy(x => x.Key))
            {
                sb.AppendLine($"--Owner: {item.Key}");
                sb.AppendLine($"    - Adopted animals: {string.Join(" ", item.Value)}");
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
