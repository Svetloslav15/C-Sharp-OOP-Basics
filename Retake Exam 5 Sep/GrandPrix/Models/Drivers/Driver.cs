using GrandPrix.Models.Tyres;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandPrix.Models.Drivers
{
    public abstract class Driver
    {
        public string Name { get; }
        public Car Car { get; set; }
        public double FuelConsumptionPerKm { get; set; }
        public virtual double Speed => (this.Car.Hp + this.Car.Tyre.Degradation) / this.Car.FuelAmount;
        public double TotalTime = 0.0;

        private string status => this.isRacing ? this.TotalTime.ToString() : this.FailureReason;
        public bool isRacing { get; private set; }
        public string FailureReason { get; private set; }

        protected Driver(string name, Car car, double fuelConsumptionPerKm)
        {
            this.Name = name;
            this.Car = car;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }
        public override string ToString()
        {
            return $"{this.Name} {this.status}";
        }

        public void Refuel(string[] methodArgs)
        {
            double fuelAmount = double.Parse(methodArgs[0]);
            this.Car.Refuel(fuelAmount);
        }

        public void ChangeTyres(Tyre tyre)
        {
            this.Car.ChangeTyres(tyre);
        }

        public void CompleteLap(int trackLength)
        {
            this.TotalTime += 60 / (trackLength / this.Speed);
            this.Car.CompleteLap(trackLength, this.FuelConsumptionPerKm);
        }

        public void Fail(string message)
        {
            this.isRacing = false;
            this.FailureReason = message;
        }
    }
}
