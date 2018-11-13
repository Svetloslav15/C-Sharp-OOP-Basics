public class WaterMonument : Monument
{
    public int WaterAffinity { get; private set; }

    public WaterMonument(string name, int waterAffinity)
        : base(name)
    {
        this.WaterAffinity = waterAffinity;
    }
}