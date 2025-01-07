class Man : Boy
{

    public override void Describe()
    {
        // Console.WriteLine("We first");
        // base.Describe();
        // Console.WriteLine("I am man");
        Console.WriteLine($"{Name} is {Height}m tall man");
    }

    public void Dance()
    {
        Console.WriteLine($"{Name} loves to dance");
    }
}

interface IHuman
{
    string Name { get; set; }
}