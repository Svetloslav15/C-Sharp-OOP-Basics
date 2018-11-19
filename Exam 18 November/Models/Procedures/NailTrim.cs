using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnimalCentre.Models.Animals;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Procedures
{
    public class NailTrim : Procedure
    {
        public override void DoService(IAnimal animal, int procedureTime)
        {
            if (animal.ProcedureTime < procedureTime)
            {
                throw new ArgumentException("Animal doesn't have enough procedure time");
            }
            animal.Happiness -= 7;
            this.ProcedureHistory.Add(animal);
        }
    }
}
