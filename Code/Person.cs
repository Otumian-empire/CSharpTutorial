public class Person
{
    int age;
    private string? name;

    public Person()
    {
        Console.WriteLine("hi there, I am a person");
    }

    public Person(string name)
    {
        this.name = name;
        Console.WriteLine($"hi there, I am {this.name}");
    }

    public void SayHi()
    {
        Console.WriteLine("hi");
    }

    public string GetName()
    {
        return this.name!;
    }

    public void SetName(string value)
    {
        this.name = value;
    }

    // replace GetName and SetName with the Property { get; set; }
    public string Name
    {
        get { return name!; }
        set { name = value; }
    }
}