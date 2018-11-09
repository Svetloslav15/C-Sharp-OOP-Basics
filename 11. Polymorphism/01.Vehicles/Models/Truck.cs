using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption + 1.6)
        {
        }
        public override void Refuel(double quantity)
        {
            base.Refuel(quantity * 0.95);
        }
    }
}
