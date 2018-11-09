using GrandPrix.Models.Tyres;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandPrix.Models
{
    public class Car
    {
        private double fuelAmount;
        public int Hp { get; }
        public double FuelAmount
        {
            get => this.fuelAmount;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ErrorMessages.OutOfFuel);
                }
                this.fuelAmount = Math.Min(value, 160);
            }
        }
        public Tyre Tyre { get; private set; }
        public Car(int hp, double fuelAmount, Tyre tyre)
        {
            this.Hp = hp;
            this.FuelAmount = fuelAmount;
            this.Tyre = tyre;
        }

        public void ChangeTyres(Tyre tyre)
        {
            this.Tyre = tyre;
        }

        public void Refuel(double fuelAmount)
        {
            this.FuelAmount += fuelAmount;
        }

        public void CompleteLap(int trackLength, double fuelConsumption)
        {
            this.fuelAmount -= trackLength * fuelConsumption;
            this.Tyre.CompleteLab();
        }
    }
}