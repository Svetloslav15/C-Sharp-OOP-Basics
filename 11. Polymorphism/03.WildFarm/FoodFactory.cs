using DefiningClasses.Contacts;
using DefiningClasses.Models.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public static class FoodFactory
    {
        public static IFood CreateFood(string[] tokens)
        {
            int quantity = int.Parse(tokens[1]);
            switch (tokens[0])
            {
                case nameof(Vegetable): return new Vegetable(quantity);
                case nameof(Fruit): return new Fruit(quantity);
                case nameof(Meat): return new Meat(quantity);
                case nameof(Seeds): return new Seeds(quantity);
                default: throw new ArgumentException("Invalid Food!");
            }
        }
    }
}
