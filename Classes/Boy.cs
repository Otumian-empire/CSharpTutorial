class Boy
{
    private string name; // field

    public string Name // property that encapsulates 'name'
    {
        get { return name; }
        set { name = value; }
    }

    // private double height;
    public double Height { get; set; } // same as above but a short hand (automatic properties)


    public virtual void Describe()
    {
        Console.WriteLine($"{Name} is {Height}m tall");
    }
}