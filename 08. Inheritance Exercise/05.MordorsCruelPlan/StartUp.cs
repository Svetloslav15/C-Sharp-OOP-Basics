using DefiningClasses.Foods;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<Food> foods = new List<Food>();
            foreach (var item in input)
            {
                Food food = GetFood(item);
                foods.Add(food);
            }
            int allHapiness = foods.Select(x => x.Hapineness).Sum();
            Console.WriteLine(allHapiness);
            if (allHapiness < -5)
            {
                Console.WriteLine("Angry");
            }
            else if (allHapiness < 0)
            {
                Console.WriteLine("Sad");
            }
            else if (allHapiness < 16)
            {
                Console.WriteLine("Happy");
            }
            else
            {
                Console.WriteLine("JavaScript");
            }
        }

        private static Food GetFood(string item)
        {
            Food food;
            item = item.ToLower();
            if (item == "apple")
            {
                food = new Apple();
            }
            else if (item == "cram")
            {
                food = new Cram();
            }
            else if (item == "honeycake")
            {
                food = new HoneyCake();
            }
            else if (item == "lembas")
            {
                food = new Lembas();
            }
            else if (item == "melon")
            {
                food = new Melon();
            }
            else if (item == "mushrooms")
            {
                food = new Mushrooms();
            }
            else
            {
                food = new Other();
            }
            return food;
        }
    }
}
