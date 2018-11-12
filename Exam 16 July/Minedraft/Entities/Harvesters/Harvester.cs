using System;

public abstract class Harvester : IIdentifiable
{
    private double oreOutput;
    private double energyRequirement;

    public string Id { get; }
    public double OreOutput
    {
        get => this.oreOutput;
        set
        {
            ExceptionHandler.NagativeOreOutput(value);
            this.oreOutput = value;
        }
    }
    public double EnergyRequirement
    {
        get => this.energyRequirement;
        set
        {
            ExceptionHandler.EnergyRequirement(value);
            this.energyRequirement = value;
        }
    }

    protected Harvester(string id, double oreoutput, double energyrequirement)
    {
        this.Id = id;
        this.OreOutput = oreoutput;
        this.EnergyRequirement = energyrequirement;
    }
    public string GetTypeName()
    {
        string name = this.GetType().Name;
        name = name.Substring(0, name.IndexOf("Harvester"));
        return name;
    }
    public override string ToString()
    {
        return $"{this.GetTypeName()} Harvester - {Id}{Environment.NewLine}" +
               $"Ore Output: {OreOutput}{Environment.NewLine}" +
               $"Energy Requirement: {EnergyRequirement}";
    }
}
