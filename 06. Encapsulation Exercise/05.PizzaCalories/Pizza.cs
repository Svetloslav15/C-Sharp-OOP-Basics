using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> Toppings;

        public string Name
        {
            get => this.name;
            private set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException ($"Pizza name should be between {1} and {15} symbols.");
                }
                this.name = value;
            }
        }

        public Dough Dough
        {
            get => this.dough;
            set => this.dough = value;
        }

        public Pizza(string name)
        {
            this.Name = name;
            this.Toppings = new List<Topping>();
        }

        public double CalculateAllCalories()
        {
            double result = 0.0;
            this.Toppings.ForEach(x => result += x.Calories());
            result += this.Dough.Calories();
            return result;
        }
        public void AddTopping(Topping topping)
        { 
            if (this.NumberOfToppings() > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.Toppings.Add(topping);
        }
        public int NumberOfToppings()
        {
            return this.Toppings.Count;
        }
        public override string ToString()
        {
            return $"{this.Name} - {this.CalculateAllCalories():f2} Calories.";
        }
    }
}