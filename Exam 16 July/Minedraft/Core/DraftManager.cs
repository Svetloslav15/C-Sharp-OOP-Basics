using System;
using System.Collections.Generic;
using System.Linq;

public class DraftManager
{
    private string mode;
    private double totalStoredEnergy;
    private double totalMinedOre;
    private List<Harvester> harvesters;
    private List<Provider> providers;
    private Dictionary<string, double> energyRequirementMode;
    private Dictionary<string, double> oreOutputMode;

    public DraftManager()
    {
        this.totalMinedOre = 0;
        this.totalStoredEnergy = 0;
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
        this.mode = "Full";

        energyRequirementMode = new Dictionary<string, double>();
        this.energyRequirementMode["Full"] = 1.0;
        this.energyRequirementMode["Half"] = 0.6;
        this.energyRequirementMode["Energy"] = 0.0;

        oreOutputMode = new Dictionary<string, double>();
        this.oreOutputMode["Full"] = 1.0;
        this.oreOutputMode["Half"] = 0.5;
        this.oreOutputMode["Energy"] = 0.0;
    }

    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            Harvester harvester = HarvesterFactory.CreateHarvester(arguments);
            this.harvesters.Add(harvester);
            return $"Successfully registered {harvester.GetTypeName()} Harvester - {harvester.Id}";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            Provider provider = ProviderFactory.CreateProvider(arguments);
            this.providers.Add(provider);
            return $"Successfully registered {provider.GetTypeName()} Provider - {provider.Id}";
        }
        catch (Exception ex)
        {

            return ex.Message;
        }
    }

    public string Day()
    {
        double summedOreOutput = 0;
        double energyModifier = this.energyRequirementMode[this.mode];
        double oreModifier = this.oreOutputMode[this.mode];
        double summedEnergy = this.providers.Select(x => x.EnergyOutput).Sum();
        this.totalStoredEnergy += summedEnergy;

        double energyRequired = this.harvesters.Select(x => x.EnergyRequirement).Sum();

        if (energyRequired <= this.totalStoredEnergy)
        {
            summedOreOutput = this.harvesters.Select(x => x.OreOutput * oreModifier).Sum();
            this.totalMinedOre += summedOreOutput;
            this.totalStoredEnergy -= energyRequired;
        }
        return $"A day has passed.\n" +
            $"Energy Provided: {summedEnergy}\n" +
            $"Plumbus Ore Mined: {summedOreOutput}";
    }

    public string Mode(List<string> arguments)
    {
        string mode = arguments[0];
        if (mode == "Full" || mode == "Half" || mode == "Energy")
        {
            this.mode = mode;
        }
        return $"Successfully changed working mode to {this.mode} Mode";
    }

    public string Check(List<string> arguments)
    {
        string id = arguments[0];
        var provider = this.providers.FirstOrDefault(x => x.Id == id);
        if (provider != null)
        {
            return provider.ToString();
        }
        var harvester = this.harvesters.FirstOrDefault(x => x.Id == id);
        if (harvester != null)
        {
            return harvester.ToString();
        }
        return $"No element found with id - {id}";
    }

    public string ShutDown()
    {
        return "System Shutdown\n" +
                $"Total Energy Stored: {this.totalStoredEnergy}\n" + 
                $"Total Mined Plumbus Ore: {this.totalMinedOre}";
    }

}