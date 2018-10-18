using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> tree = new List<Person>();
            string searchFor = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 1)
                {
                    string[] newTokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string firstname = newTokens[0];
                    string lastname = newTokens[1];
                    string birthday = newTokens[2];
                    Person person = new Person(firstname, lastname, birthday);
                    tree.Add(person);
                }
                else if (tokens[0].Contains(" "))
                {
                    string[] newTokens = tokens[0].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string firstnameParent = newTokens[0];
                    string lastnameParent = newTokens[1];
                    Person parent = new Person(firstnameParent, lastnameParent);
                    if (tokens[1].Contains(" "))
                    {
                        newTokens = tokens[1].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        string firstnameChild = newTokens[0];
                        string lastnameChild = newTokens[1];
                        Person person = new Person(firstnameChild, lastnameChild);
                        person.AddParent(parent);
                        parent.AddChild(person);
                    }
                    else
                    {
                        Person person = new Person(tokens[1]);
                        person.AddParent(parent);
                        parent.AddChild(person);
                    }
                }
                else if (tokens[1].Contains(" "))
                {
                    string parentBirthday = tokens[0];
                    Person parent = new Person(parentBirthday);
                    string[] newTokens = tokens[1].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string firstnameChild = newTokens[0];
                    string lastnameChild = newTokens[1];
                    Person person = new Person(firstnameChild, lastnameChild);
                    person.AddParent(parent);
                    parent.AddChild(person);
                }
                else
                {
                    Person parent = new Person(tokens[0]);
                    Person person = new Person(tokens[0]);
                    person.AddParent(parent);
                    parent.AddChild(person);
                }
                input = Console.ReadLine();
            }

            if (searchFor.Contains(" "))
            {
                string[] tokens = searchFor.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = tree.First(x => x.FirstName == tokens[0] && x.Lastname == tokens[1]);
                Console.WriteLine(person);
            }
            else
            {
                Person person = tree.First(X => X.Birthday == searchFor);
                Console.WriteLine(person);
            }
        }
    }
}
