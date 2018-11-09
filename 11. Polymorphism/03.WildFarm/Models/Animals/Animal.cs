using DefiningClasses;
using DefiningClasses.Contacts;
using System;
namespace DefiningClasses.Models
{
    public abstract class Animal : IAnimal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; protected set; }

        public abstract string AskForFood();

        public virtual void Eat(IFood food, int quantity)
        {
            this.FoodEaten += quantity;
            var increasingNumber = WeightMultiplier.IncreasingNumber(this);
            this.Weight += quantity * increasingNumber;
        }

        protected string WrongFood(IFood food)
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
    }
}