using DefiningClasses.Contacts;
using DefiningClasses.Models.Food;

namespace DefiningClasses.Models.Animals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }
        public override void Eat(IFood food, int quantity)
        {
            if (food is Meat)
            {
                base.Eat(food, quantity);
            }
            else
            {
                base.WrongFood(food);
            }
        }
        public override string AskForFood()
        {
            return "Woof!";
        }
    }
}
