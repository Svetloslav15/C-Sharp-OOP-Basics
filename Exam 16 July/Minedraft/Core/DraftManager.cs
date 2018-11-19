using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private ICollection<Provider> providers;
    private ICollection<Harvester> harvesters;

    private double totalStoredEnergy;
    private double totalMinedOre;
    private Modes mode;

    public DraftManager()
    {
        this.providers = new List<Provider>();
        this.harvesters = new List<Harvester>();
    }

    public string RegisterHarvester(List<string> arguments)
    {
        Harvester harvester = HarvesterFactory.CreateHarvester(arguments);
        this.harvesters.Add(harvester);
        return $"Successfully registered {harvester.GetType().Name.Replace("Harvester", "")} Harvester - {harvester.Id}";
    }

    public string RegisterProvider(List<string> arguments)
    {
        Provider provider = ProviderFactory.CreateProvider(arguments);
        this.providers.Add(provider);
        return $"Successfully registered {provider.GetType().Name.Replace("Provider", "")} Provider - {provider.Id}";
    }

    public string Day()
    {
        double currentEnergy = this.providers.Sum(x => x.EnergyOutput);
        this.totalStoredEnergy += currentEnergy;
        double neededEnergy = this.harvesters.Sum(x => x.EnergyRequirement) * this.EnergyModeModifier();
        double summedOreOutput = 0.0;
        if (neededEnergy <= this.totalStoredEnergy)
        {
            this.totalStoredEnergy -= neededEnergy;
            summedOreOutput = this.harvesters.Sum(x => x.OreOutput) * this.OreModeModifier();
            this.totalMinedOre += summedOreOutput;
        }
        StringBuilder result = new StringBuilder();
        result.AppendLine("A day has passed.");
        result.AppendLine($"Energy Provided: {currentEnergy}");
        result.AppendLine($"Plumbus Ore Mined: {summedOreOutput}");
        return result.ToString().Trim();
    }

    public string Mode(List<string> arguments)
    {
        if (Enum.TryParse(typeof(Modes), arguments[0], out object newMode))
        {
            this.mode = (Modes)newMode;
            return $"Successfully changed working mode to {this.mode} Mode";
        }
        throw new ArgumentException("Invalid Mode Type!");

    }

    public string Check(List<string> arguments)
    {
        string id = arguments[0];
        Provider provider = this.providers.FirstOrDefault(x => x.Id == id);
        if (provider == null)
        {
            Harvester harvester = this.harvesters.FirstOrDefault(x => x.Id == id);
            if (harvester == null)
            {
                throw new ArgumentException($"No element found with id - {id}");
            }
            return harvester.ToString();
        }
        return provider.ToString();
    }

    public string ShutDown()
    {
        StringBuilder result = new StringBuilder();
        result.AppendLine("System Shutdown");
        result.AppendLine($"Total Energy Stored: {this.totalStoredEnergy}");
        result.AppendLine($"Total Mined Plumbus Ore: {this.totalMinedOre}");
        return result.ToString().Trim();
    }

    private double EnergyModeModifier()
    {
        if (this.mode == Modes.Full) return 1.0;
        else if (this.mode == Modes.Half) return 0.60;
        else return 0;
    }

    private double OreModeModifier()
    {
        if (this.mode == Modes.Full) return 1.0;
        else if (this.mode == Modes.Half) return 0.50;
        else return 0;
    }
}