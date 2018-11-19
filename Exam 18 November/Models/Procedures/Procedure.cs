using AnimalCentre.Models.Animals;
using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Procedures
{
    public abstract class Procedure : IProcedure
    {
        private List<IAnimal> procedureHistory;

        public ICollection<IAnimal> ProcedureHistory
        {
            get => this.procedureHistory;
        }
        protected Procedure()
        {
            this.procedureHistory = new List<IAnimal>();
        }

        public abstract void DoService(IAnimal animal, int procedureTime);

        public string History()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{this.GetType().Name}");
            foreach (Animal animal in this.ProcedureHistory)
            {
                stringBuilder.AppendLine(animal.ToString());
            }
            return stringBuilder.ToString().TrimEnd();
        }
    }
}
