using System;

public abstract class Tyre
{
    public string Name { get; private set; }
    public double Hardness { get; private set; }
    private double degradation;
    public virtual double Degradation
    {
        get => this.degradation;
        protected set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Blown Tyre");
            }
        }
    }

    protected Tyre(string name, double hardness)
    {
        this.Name = name;
        this.Hardness = hardness;
        this.Degradation = 100;
    }

    public virtual void ReduceDegradation()
    {
        this.Degradation -= this.Hardness;
    }
}