using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Dough
    {
        private string type;
        private string technique;
        private int weight;

        public int Weight
        {
            get => this.weight;
            set { weight = value; }
        }


        public string Technique
        {
            get => this.technique;
            private set
            {
                if (value != "crispy" && value != "chewy" && value != "homemade")
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
                if (value != "white" && value != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.type = value;
            }
        }

        public Dough(string type, string technique)
        {
            this.Type = type;
            this.Technique = technique;
        }
    }
}
