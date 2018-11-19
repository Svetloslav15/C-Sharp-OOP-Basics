using AnimalCentre.Factories;
using AnimalCentre.Models.Animals;
using AnimalCentre.Models.Contracts;
using AnimalCentre.Models.Hotels;
using AnimalCentre.Models.Procedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalCentre.Core
{
    public class AnimalCentre
    {
        private Hotel hotel;
        private Chip chip;
        private Vaccinate vaccinate;
        private DentalCare dentalCare;
        private Fitness fitness;
        private NailTrim nailTrim;
        private Play play;
        public Dictionary<string, List<string>> adoptedAnimals;

        public AnimalCentre()
        {
            hotel = new Hotel();
            chip = new Chip();
            vaccinate = new Vaccinate();
            dentalCare = new DentalCare();
            fitness = new Fitness();
            nailTrim = new NailTrim();
            play = new Play();
            adoptedAnimals = new Dictionary<string, List<string>>();
        }

        public string RegisterAnimal(string type, string name, int energy, int happiness, int procedureTime)
        {
            AnimalFactory animalFactory = new AnimalFactory();
            Animal animal = animalFactory.CreateAnimal(type, name, energy, happiness, procedureTime);
            if (Hotel.Capacity == hotel.Animals.Count)
            {
                throw new InvalidOperationException("Not enough capacity");
            }
            if (hotel.Animals.ContainsKey(animal.Name))
            {
                throw new ArgumentException($"Animal {animal.Name} already exist");
            }
            hotel.Accommodate(animal);

            return $"Animal {animal.Name} registered successfully";
        }

        public string Chip(string name, int procedureTime)
        {
            if (hotel.Animals.ContainsKey(name) == false)
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }
            IAnimal currentAnimal = hotel.Animals.FirstOrDefault(x => x.Key == name).Value;

            chip.DoService(currentAnimal, procedureTime);
            return $"{currentAnimal.Name} had chip procedure";
        }

        public string Vaccinate(string name, int procedureTime)
        {
            if (hotel.Animals.ContainsKey(name) == false)
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }
            IAnimal currentAnimal = hotel.Animals.FirstOrDefault(x => x.Key == name).Value;
            vaccinate.DoService(currentAnimal, procedureTime);

            return $"{currentAnimal.Name} had vaccination procedure";
        }

        public string Fitness(string name, int procedureTime)
        {
            if (hotel.Animals.ContainsKey(name) == false)
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }
            IAnimal currentAnimal = hotel.Animals.FirstOrDefault(x => x.Key == name).Value;
            fitness.DoService(currentAnimal, procedureTime);

            return $"{currentAnimal.Name} had fitness procedure";
        }

        public string Play(string name, int procedureTime)
        {
            if (hotel.Animals.ContainsKey(name) == false)
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }
            IAnimal currentAnimal = hotel.Animals.FirstOrDefault(x => x.Key == name).Value;
            play.DoService(currentAnimal, procedureTime);
            return $"{currentAnimal.Name} was playing for {procedureTime} hours";
        }

        public string DentalCare(string name, int procedureTime)
        {
            if (hotel.Animals.ContainsKey(name) == false)
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }
            IAnimal currentAnimal = hotel.Animals.FirstOrDefault(x => x.Key == name).Value;
            dentalCare.DoService(currentAnimal, procedureTime);
            return $"{currentAnimal.Name} had dental care procedure";
        }

        public string NailTrim(string name, int procedureTime)
        {
            if (hotel.Animals.ContainsKey(name) == false)
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }
            IAnimal currentAnimal = hotel.Animals.FirstOrDefault(x => x.Key == name).Value;
            nailTrim.DoService(currentAnimal, procedureTime);
            return $"{currentAnimal.Name} had nail trim procedure";
        }

        public string Adopt(string animalName, string owner)
        {
            if (hotel.Animals.ContainsKey(animalName) == false)
            {
                throw new ArgumentException($"Animal {animalName} does not exist");
            }
            IAnimal animal = hotel.Animals.FirstOrDefault(x => x.Key == animalName).Value;
            string output = "";
            hotel.Adopt(animalName, owner);

            if (animal.IsChipped == true)
            {
                output = $"{owner} adopted animal with chip";
            }
            else
            {
                output = $"{owner} adopted animal without chip";
            }
            if (adoptedAnimals.ContainsKey(owner) == false)
            {
                this.adoptedAnimals[owner] = new List<string>();
            }
            adoptedAnimals[owner].Add(animalName);
            return output;
        }

        public string History(string type)
        {
            string result = "";
            switch (type)
            {
                case "Chip": result = chip.History();break;
                case "Vaccinate": result = vaccinate.History();break;
                case "DentalCare": result = dentalCare.History();break;
                case "Fitness": result = fitness.History();break;
                case "NailTrim": result = nailTrim.History();break;
                case "Play": result = play.History();break;                 
            }
            return result;
        }
    }
}