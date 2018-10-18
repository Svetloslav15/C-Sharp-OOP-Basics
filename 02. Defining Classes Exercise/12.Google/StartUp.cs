using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Person> people = new List<Person>();
            while (input != "End")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                Person person = new Person("ffsd");
                if (!people.Any(x => x.Name == name))
                {
                    person = new Person(name);
                }
                else
                {
                    for (int i = 0; i < people.Count; i++)
                    {
                        if (people[i].Name == name)
                        {
                            person = people[i];
                            break;
                        }
                    }
                }
                if (tokens[1] == "company")
                {
                    string companyName = tokens[2];
                    string department = tokens[3];
                    decimal salary = decimal.Parse(tokens[4]);
                    Company company = new Company(companyName, department, salary);
                    person.AddCompany(company);
                }
                else if (tokens[1] == "pokemon")
                {
                    string pokemonName = tokens[2];
                    string pokemonType = tokens[3];
                    Pokemon pokemon = new Pokemon(pokemonName, pokemonType);
                    person.AddPokemon(pokemon);
                }
                else if (tokens[1] == "parents")
                {
                    string parentName = tokens[2];
                    string date = tokens[3];
                    Parent parent = new Parent(parentName, date);
                    person.AddParent(parent);
                }
                else if (tokens[1] == "children")
                {
                    string childName = tokens[2];
                    string date = tokens[3];
                    Child child = new Child(childName, date);
                    person.AddChild(child);
                }
                else if (tokens[1] == "car")
                {
                    string carModel = tokens[2];
                    int carSpeed = int.Parse(tokens[3]);
                    Car car = new Car(carModel, carSpeed);
                    person.AddCar(car);
                }
                people.Add(person);
                input = Console.ReadLine();
            }
            string pers = Console.ReadLine();
            Console.WriteLine(people.First(x => x.Name == pers));
        }
    }
}