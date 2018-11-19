using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private DraftManager draftManager;
    public Engine()
    {
        this.draftManager = new DraftManager();
    }

    public void Run()
    {
        string input = Console.ReadLine();
        while (true)
        {
            try
            {
                List<string> tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                string command = tokens[0];
                tokens.RemoveAt(0);
                switch (command)
                {
                    case "RegisterHarvester":
                        Print(this.draftManager.RegisterHarvester(tokens)); break;
                    case "RegisterProvider":
                        Print(this.draftManager.RegisterProvider(tokens)); break;
                    case "Day":
                        Print(this.draftManager.Day()); break;
                    case "Mode":
                        Print(this.draftManager.Mode(tokens)); break;
                    case "Check":
                        Print(this.draftManager.Check(tokens)); break;
                    case "Shutdown":
                        Print(this.draftManager.ShutDown());
                        return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            input = Console.ReadLine();
        }
    }
    private void Print(string text)
    {
        Console.WriteLine(text);
    }
}