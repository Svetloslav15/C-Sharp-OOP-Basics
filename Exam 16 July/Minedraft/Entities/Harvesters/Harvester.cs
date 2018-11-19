using System;
using System.Text;

public abstract class Harvester
{
    public string Id { get; set; }
    private double oreOutput;
    private double energyRequirement;

    protected Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.Id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }
    public double OreOutput
    {
        get => this.oreOutput;
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(this.OreOutput)}");
            }
            this.oreOutput = value;
        }
    }
    public double EnergyRequirement 
    {
        get => this.energyRequirement;
        protected set
        {
            if (value < 0 || value > 20000)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(this.EnergyRequirement)}");
            }
            this.energyRequirement = value;
        }
    }
    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine($"{this.GetType().Name.Replace("Harvester", "")} Harvester - {this.Id}");
        builder.AppendLine($"Ore Output: {this.OreOutput}");
        builder.Append($"Energy Requirement: {this.EnergyRequirement}");

        return builder.ToString();
    }
}