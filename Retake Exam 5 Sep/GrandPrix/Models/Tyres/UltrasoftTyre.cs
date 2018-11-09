using System;
using System.Collections.Generic;
using System.Text;

namespace GrandPrix.Models.Tyres
{
    public class UltrasoftTyre : Tyre
    {
        public double Grip { get; set; }

        public UltrasoftTyre(double hardness, double grip)
            : base("Ultrasoft", hardness)
        {
            this.Grip = grip;
        }
        public override void CompleteLab()
        {
            base.CompleteLab();
            this.Degradation -= this.Grip;
            if (this.Degradation < 30)
            {
                throw new ArgumentException(ErrorMessages.BlownTyre);
            }
        }
    }
}
