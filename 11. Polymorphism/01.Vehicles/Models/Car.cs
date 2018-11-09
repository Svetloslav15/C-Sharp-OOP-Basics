using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption + 0.9)
        {
        }
    }
}
