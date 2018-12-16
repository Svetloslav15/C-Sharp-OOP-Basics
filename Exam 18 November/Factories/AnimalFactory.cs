using AnimalCentre.Models.Animals;
using AnimalCentre.Models.Contracts;
using AnimalCentre.Models.Hotels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AnimalCentre.Factories
{
    public class AnimalFactory
    {
        public Animal CreateAnimal(string type, string name, int energy, int happiness, int procedureTime)
        {
            Type typef = Assembly.GetExecutingAssembly()
                 .GetTypes()
                 .FirstOrDefault(x => x.Name == type);

            return (Animal)Activator.CreateInstance(typef);
        }
    }
}
