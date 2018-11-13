public class FireMonument : Monument
{
    public int FireAffinity { get; private set; }

    public FireMonument(string name, int fireAffinity)
        : base(name)
    {
        this.FireAffinity = fireAffinity;
    }
}