class Car
{
    public string color;

    public Car(string carColor)
    {
        color = carColor;
    }

    public void PrintColor()
    {
        Console.WriteLine($"This car's color is {color}");
    }
}