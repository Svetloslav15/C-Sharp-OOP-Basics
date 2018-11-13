public class EarthMonument : Monument
{
    public int EarthAffinity { get; private set; }

    public EarthMonument(string name, int earthAffinity)
        : base(name)
    {
        this.EarthAffinity = earthAffinity;
    }
}