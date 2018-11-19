public class SonicHarvester : Harvester
{
    public int SonicFactory { get; }
    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactory) 
        : base(id, oreOutput, energyRequirement)
    {
        this.SonicFactory = sonicFactory;
        this.EnergyRequirement /= this.SonicFactory;
    }
}