using AnimalCentre.Models.Animals;
using AnimalCentre.Models.Hotels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Factories
{
    public class AnimalFactory
    {
        public Animal CreateAnimal(string type, string name, int energy, int happiness, int procedureTime)
        {
            switch (type)
            {
                case "Cat":
                    return new Cat(name, energy, happiness, procedureTime);
                case "Dog":
                    return new Dog(name, energy, happiness, procedureTime);
                case "Lion":
                    return new Lion(name, energy, happiness, procedureTime);
                case "Pig":
                    return new Pig(name, energy, happiness, procedureTime);
                default:
                    return null;
            }
        }
    }
}
