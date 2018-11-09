using DefiningClasses.Contacts;
using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            List<IAnimal> animals = new List<IAnimal>();
            string input = Console.ReadLine();
 
            while (input != "End")
            {
                string[] animalTokens = input.Split();
                string[] foodTokens = Console.ReadLine().Split();

                IAnimal animal = AnimalFactory.CreateAnimal(animalTokens);
                IFood food = FoodFactory.CreateFood(foodTokens);
                Console.WriteLine(animal.AskForFood());

                try
                {
                    animal.Eat(food, food.Quantity);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                animals.Add(animal);
                input = Console.ReadLine();
            }

            animals.ForEach(x => Console.WriteLine(x));
        }
    }
}
