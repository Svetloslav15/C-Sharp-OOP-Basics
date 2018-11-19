public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput) : base(id, energyOutput)
    {
        this.EnergyOutput += 0.5 * this.EnergyOutput;
    }
}