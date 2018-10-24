using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Dough
    {
        private string type;
        private string technique;
        private double weight;
        private Dictionary<string, double> modifiers;

        public double Weight
        {
            get => this.weight;
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }
        public string Technique
        {
            get => this.technique;
            private set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.technique = value;
            }
        }
        public string Type
        {
            get => this.type;
            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.type = value;
            }
        }

        public double Calories()
        {
            return this.weight * modifiers[this.technique.ToLower()] * modifiers[this.type.ToLower()] * 2;
        }
        public Dough(string type, string technique, double weight)
        {
            this.Type = type;
            this.Technique = technique;
            this.Weight = weight;
            this.modifiers = new Dictionary<string, double>();
            modifiers["white"] = 1.5;
            modifiers["wholegrain"] = 1.0;
            modifiers["crispy"] = 0.9;
            modifiers["chewy"] = 1.1;
            modifiers["homemade"] = 1.50;
        }
    }
}
