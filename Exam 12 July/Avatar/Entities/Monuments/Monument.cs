public abstract class Monument
{
    public string Name { get; private set; }
    protected Monument(string name)
    {
        this.Name = name;
    }
    public string GetTypeName()
    {
        string name = this.GetType().Name;
        int index = name.IndexOf("Monument");
        return name.Substring(0, index);
    }
}