using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnimalCentre.Models.Animals;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Procedures
{
    public class Vaccinate : Procedure
    {
        public override void DoService(IAnimal animal, int procedureTime)
        {
            if (animal.ProcedureTime < procedureTime)
            {
                throw new ArgumentException("Animal doesn't have enough procedure time");
            }
            animal.Energy -= 8;
            animal.IsVaccinated = true;
            this.ProcedureHistory.Add(animal);
        }
    }
}
