using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Engine
{
    private NationsBuilder nationsBuilder;
    public Engine()
    {
        this.nationsBuilder = new NationsBuilder();
    }
    public void Run()
    {
        bool isRunning = true;

        while (isRunning)
        {
            List<string> tokens = Console.ReadLine().Split().ToList();
            string command = tokens[0];
            switch (command)
            {
                case "Bender":
                    this.nationsBuilder.AssignBender(tokens.Skip(0).ToList());break;
                case "Monument":
                    this.nationsBuilder.AssignMonument(tokens.Skip(0).ToList()); break;
                case "Status":
                    string result = this.nationsBuilder.GetStatus(tokens[1]);
                    Console.WriteLine(result);
                    break;
                case "War":
                    this.nationsBuilder.IssueWar(tokens[1]); break;
                case "Quit":
                    string output = this.nationsBuilder.GetWarsRecord();
                    Console.WriteLine(output);
                    isRunning = false;
                    break;
            }
        }
    }
}