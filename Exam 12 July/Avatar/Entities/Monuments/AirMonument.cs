public class AirMonument : Monument
{
    public int AirAffinity { get; private set; }

    public AirMonument(string name, int airAffinity)
        : base(name)
    {
        this.AirAffinity = airAffinity;
    }
}