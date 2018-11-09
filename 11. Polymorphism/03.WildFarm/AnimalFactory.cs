using DefiningClasses.Contacts;
using DefiningClasses.Models.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public static class AnimalFactory
    {
        public static IAnimal CreateAnimal(string[] tokens)
        {
            var animalType = tokens[0];
            switch (animalType)
            {
                case nameof(Cat):
                    return new Cat(tokens[1], double.Parse(tokens[2]), tokens[3], tokens[4]);
                case nameof(Tiger):
                    return new Tiger(tokens[1], double.Parse(tokens[2]), tokens[3], tokens[4]);
                case nameof(Dog):
                    return new Dog(tokens[1], double.Parse(tokens[2]), tokens[3]);
                case nameof(Mouse):
                    return new Mouse(tokens[1], double.Parse(tokens[2]), tokens[3]);
                case nameof(Owl):
                    return new Owl(tokens[1], double.Parse(tokens[2]), double.Parse(tokens[3]));
                case nameof(Hen):
                    return new Hen(tokens[1], double.Parse(tokens[2]), double.Parse(tokens[3]));
                default:
                    throw new NotImplementedException("Current Animal Type Does Not Exist!");
            }
        }
    }
}
