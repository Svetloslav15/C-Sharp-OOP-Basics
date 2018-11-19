using AnimalCentre.Models.Animals;
using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalCentre.Models.Hotels
{
    public class Hotel : IHotel
    {
        public Dictionary<string, IAnimal> animals;
        public const int Capacity = 10;

        public IReadOnlyDictionary<string, IAnimal> Animals
        {
            get => this.animals;
        }
        public Hotel()
        {
            this.animals = new Dictionary<string, IAnimal>();
        }

        public void Accommodate(IAnimal animal)
        {
            if (this.Animals.Count >= 10)
            {
                throw new InvalidOperationException($"Not enough capacity");
            }
            if (this.Animals.ContainsKey(animal.Name) == true)
            {
                throw new ArgumentException($"Animal {animal.Name} already exist");
            }
            this.animals.Add(animal.Name, animal);
        }

        public void Adopt(string animalName, string owner)
        {
            if (this.Animals.ContainsKey(animalName) == false)
            {
                throw new ArgumentException($"Animal {animalName} does not exist");
            }
            IAnimal animal = this.Animals.FirstOrDefault(x => x.Key == animalName).Value;
            animal.IsAdopt = true;
            animal.Owner = owner;
            this.animals.Remove(animalName);
        }
    }
}
