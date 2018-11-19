using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnimalCentre.Models.Animals;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Procedures
{
    public class Chip : Procedure
    {
        public override void DoService(IAnimal animal, int procedureTime)
        {
            if (animal.ProcedureTime < procedureTime)
            {
                throw new ArgumentException("Animal doesn't have enough procedure time");
            }
            if (animal.IsChipped == true)
            {
                throw new ArgumentException($"{animal.Name} is already chipped");
            }
            animal.IsChipped = true;
            animal.Happiness -= 5;
            animal.ProcedureTime -= procedureTime;
            this.ProcedureHistory.Add(animal);
        }
    }
}