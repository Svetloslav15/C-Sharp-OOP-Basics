public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreoutput, double energyrequirement)
        : base(id, oreoutput, energyrequirement)
    {
        this.OreOutput *= 3;
        this.EnergyRequirement *= 2;
    }
}
