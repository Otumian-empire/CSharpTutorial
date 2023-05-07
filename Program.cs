namespace CSharpTutorial;
class Program
{
    static void Main(string[] args)
    {
        // type[] var_name; -> declare
        // type[] var_name = new type[number_of_elements]; -> initialize
        // type[] var_name = new type[number_of_elements] { x1, x2, ...};
        // initialize with literals
        // type[] var_name = { x1, x2, ...}; -> initialize with literals
        int[] evenNumbers = new int[5] { 1, 2, 3, 4, 5 };
        Console.WriteLine(evenNumbers[0]);


        /* Person person = new Person();
        person.SayHi();
        person.SetName("Peter");

        Person bob = new Person("Bobby");
        bob.SayHi();
        Console.WriteLine(bob.GetName());

        Person mic = new Person();
        mic.Name = "Angus Slobbery";


        Dog dog = new Dog();
        dog.age = 20;
        dog.name = "Lucky";

        Console.WriteLine(dog.age);
        Console.WriteLine(dog.name); */
    }
}
