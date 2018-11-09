using System;
using System.Collections.Generic;
using System.Text;

namespace GrandPrix.Models.Tyres
{
    public abstract class Tyre
    {
        public string Name { get; }
        public double Hardness { get; }
        private double degradation;

        protected Tyre(string name, double hardness)
        {
            this.Name = name;
            this.Hardness = hardness;
            this.Degradation = 100;
        }
        public double Degradation
        {
            get => this.degradation;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ErrorMessages.BlownTyre);
                }
                this.degradation = value;
            }
        }

        public virtual void CompleteLab()
        {
            this.Degradation -= this.Hardness;
        }
    }
}