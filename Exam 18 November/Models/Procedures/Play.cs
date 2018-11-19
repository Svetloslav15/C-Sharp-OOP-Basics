using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnimalCentre.Models.Animals;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Procedures
{
    public class Play : Procedure
    {
        public override void DoService(IAnimal animal, int procedureTime)
        {
            if (animal.ProcedureTime < procedureTime)
            {
                throw new ArgumentException("Animal doesn't have enough procedure time");
            }
            animal.Energy -= 6;
            animal.Happiness += 12;
            this.ProcedureHistory.Add(animal);
        }
    }
}
