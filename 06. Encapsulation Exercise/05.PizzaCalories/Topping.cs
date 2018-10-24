using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Topping
    {
        private string type;
        private double weight;
        private Dictionary<string, double> modifiers;

        public double Weight
        {
            get { return weight; }
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
                }
                this.weight = value;
            }
        }

        public string Type
        {
            get { return type; }
            private set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" &&
                    value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.type = value;
            }
        }
        public double Calories()
        {
            return this.weight * modifiers[this.type.ToLower()] * 2;
        }

        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
            modifiers = new Dictionary<string, double>();
            modifiers["meat"] = 1.2;
            modifiers["veggies"] = 0.8;
            modifiers["cheese"] = 1.1;
            modifiers["sauce"] = 0.9;
        }
    }
}