using System.ComponentModel;
using System.Diagnostics;
using System.Net;

class MainClass
{
    public MainClass()
    {
        /* Console.WriteLine("Hello main class");
        Car car = new Car("Brown");
        Console.WriteLine(car.color);

        car.PrintColor(); */

        /* Human annah = new Human("Annabel Musah", "Petrochemical Engineer");
        annah.Describe(); */

        Boy boy = new Boy();
        boy.Name = "Bobby";
        boy.Height = 20.2;
        boy.Describe();

        Boy man = new Man();
        man.Name = "fred";
        man.Height = 23.6;
        man.Describe();
        // man will no have access to the 

        Man dan = new Man();
        dan.Describe();
        dan.Dance();
        // ((Man)man).Dance();

        Console.WriteLine(Convert.ToInt32(Numbers.Zero));
        Console.WriteLine((int)Numbers.Zero);

        Console.WriteLine(Convert.ToInt32(Numbers.One));
        Console.WriteLine((int)Numbers.Three);



        var x = 1;
        switch (x)
        {
            case 1:

                Console.WriteLine("Its one");
                break;

            case 2:
                Console.WriteLine("Its 2");
                return;
            default:
                Console.WriteLine("hmm");
                Environment.Exit(0);
                break;
        }

        Console.WriteLine(x);

    }

    public enum Numbers
    {
        Zero = 1,
        One = 3,
        Two = 5,

        Three
    }
}