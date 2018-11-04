using MilitaryElite.Contracts;
using MilitaryElite.Models;
using System;
using System.Collections.Generic;

namespace MilitaryElite.Core
{
    public class Engine
    {
        private ICollection<ISoldier> soldiers;
        public Engine()
        {
            this.soldiers = new List<ISoldier>();
        }
        public void Run()
        {
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] tokens = input.Split();
                string type = tokens[0];
                int id = int.Parse(tokens[1]);
                string firstName = tokens[2];
                string lastName = tokens[3];
                if (type == "Private")
                {
                    Private privateSoldier = GetPrivateSoldier(id, firstName, lastName, decimal.Parse(tokens[4]));

                }
                input = Console.ReadLine();
            }
        }

        private Private GetPrivateSoldier(int id, string firstName, string lastName, decimal salary)
        {
            throw new NotImplementedException();
        }
    }
}
