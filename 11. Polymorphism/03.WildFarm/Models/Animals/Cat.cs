using DefiningClasses.Contacts;
using DefiningClasses.Models.Food;

namespace DefiningClasses.Models.Animals
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override string AskForFood()
        {
            return "Meow";
        }

        public override void Eat(IFood food, int quantity)
        {
            if (!(food is Meat) && !(food is Vegetable))
            {
                base.WrongFood(food);
            }
            else
            {
                base.Eat(food, quantity);
            }
        }
    }
}
