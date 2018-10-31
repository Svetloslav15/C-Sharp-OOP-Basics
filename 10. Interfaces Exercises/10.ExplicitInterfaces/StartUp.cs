using ExplicitInterfaces.Interfaces;
using System;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Action<IPerson> PrintPerson = x => Console.WriteLine(x.GetName());
            Action<IResidental> PrintResidental = x => Console.WriteLine(x.GetName());
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                Citizen citizen = new Citizen(tokens[0], tokens[1], int.Parse(tokens[2]));
                PrintPerson(citizen);
                PrintResidental(citizen);
            }
        }
    }
}
