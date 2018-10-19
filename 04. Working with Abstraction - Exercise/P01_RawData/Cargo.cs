using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Cargo
    {
        public int cargoWeight;
        public string cargoType;

        public Cargo()
        {

        }

        public Cargo(int weight, string type)
        {
            this.cargoWeight = weight;
            this.cargoType = type;
        }
    }
}
