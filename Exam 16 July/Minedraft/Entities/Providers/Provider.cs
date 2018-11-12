using System;

public abstract class Provider : IIdentifiable
{
    public string Id { get; set; }
    private double energyOutput;

    public double EnergyOutput
    {
        get => this.energyOutput;
        set
        {
            ExceptionHandler.EnergyOutput(value);
            this.energyOutput = value;
        }
    }

    public Provider(string id, double energyOutput)
    {
        this.Id = id;
        this.EnergyOutput = energyOutput;
    }
    public string GetTypeName()
    {
        string name = this.GetType().Name;
        name = name.Substring(0, name.IndexOf("Provider"));
        return name;
    }
    public override string ToString()
    {
        return $"{this.GetTypeName()} Provider - {Id}{Environment.NewLine}" +
               $"Energy Output: {EnergyOutput}";
    }
}

