
class Human
{
    private string name;
    private string job;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Job { get; set; }

    public Human(string humanName, string humanJob)
    {
        name = humanName;
        job = humanJob;
    }

    public void Describe()
    {
        Console.WriteLine($"This is a human with name, {name}, with job, {job}.");
    }
}