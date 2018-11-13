using System;
using System.Collections.Generic;
using System.Text;

namespace GrandPrix.Entities.Tyres
{
    public class UltrasoftTyre : Tyre
    {
        public double Grip { get; set; }
        protected UltrasoftTyre(double hardness, double grip)
            : base("Ultrasoft", hardness)
        {
            this.Grip = grip;
        }

        public override double Degradation
        {
            protected set
            {
                if (value <= 30)
                {
                    throw new ArgumentException("Blown Tyre");
                }
            }
        }
        public override void ReduceDegradation()
        {
            base.ReduceDegradation();
            this.Degradation -= this.Grip;
        }
    }
}
