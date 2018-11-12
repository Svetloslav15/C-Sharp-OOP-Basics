public class SonicHarvester : Harvester
{
    public int SonicFactor { get; set; }

    public SonicHarvester(string id, double oreoutput, double energyrequirement, int sonicFactor)
        : base(id, oreoutput, energyrequirement)
    {
        this.SonicFactor = sonicFactor;
        this.EnergyRequirement /= this.SonicFactor;
    }
}