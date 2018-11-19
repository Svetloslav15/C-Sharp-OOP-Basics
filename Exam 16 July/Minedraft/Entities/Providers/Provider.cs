using System;
using System.Text;

public abstract class Provider
{
    public string Id { get; }
    private double energyOutput;

    public double EnergyOutput
    {
        get => this.energyOutput;
        protected set
        {
            if (value < 0 || value >= 10000)
            {
                throw new ArgumentException($"Provider is not registered, because of it's {nameof(this.EnergyOutput)}");
            }
            this.energyOutput = value;
        }
    }


    protected Provider(string id, double energyOutput)
    {
        this.Id = id;
        this.EnergyOutput = energyOutput;
    }
    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine($"{this.GetType().Name.Replace("Provider", "")} Provider - {this.Id}");
        builder.Append($"Energy Output: {this.EnergyOutput}");

        return builder.ToString();
    }
}