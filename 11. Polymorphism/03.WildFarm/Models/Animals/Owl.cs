using DefiningClasses.Contacts;
using DefiningClasses.Models.Food;

namespace DefiningClasses.Models.Animals
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
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
                this.WrongFood(food);
            }
        }
        public override string AskForFood()
        {
            return "Hoot Hoot";
        }
    }
}
