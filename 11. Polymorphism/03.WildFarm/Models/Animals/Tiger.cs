using DefiningClasses.Contacts;
using DefiningClasses.Models.Food;

namespace DefiningClasses.Models.Animals
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
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
            return "ROAR!!!";
        }
    }
}
