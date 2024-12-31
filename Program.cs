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
        /* int[] evenNumbers = new int[5] { 1, 2, 3, 4, 5 };
        Console.WriteLine(evenNumbers[0]);

        Console.WriteLine($"The length of the array is: {evenNumbers.Length}");
        Console.WriteLine($"The Rank of the array is: {evenNumbers.Rank}");
        Console.WriteLine($"The Min of the array is: {evenNumbers.Min()}");
        Console.WriteLine($"The Max of the array is: {evenNumbers.Max()}");
        Console.WriteLine($"The Sum of the array is: {evenNumbers.Sum()}"); */


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

        // type casting
        // TypeCasting();

        // user input
        // UserInput();

        // System.Console.WriteLine(string.Concat("Hello", " World"));
        // System.Console.WriteLine("a\b");

        // arrays
        Arrays();


    }

    static void Arrays()
    {
        // int[] intArray = { 1, 2, 3 };
        int[] intArray = [1, 2, 3]; // using collection expression
        foreach (var i in intArray)
        {
            Console.WriteLine(intArray);
        }

        string[] stringArray1 = new string[] { "firstStr", "secondStr" };
        string[] stringArray2 = new string[2] { "firstStr", "secondStr" };
        string[] stringArray3 = new string[2];
        stringArray3 = ["firstStr", "secondStr"];

        string[] stringArray4;
        stringArray4 = new string[] { "1", "2", "3" };
        // stringArray4 =  { "1", "2", "3" };// will cause error
        stringArray4 = ["1", "2", "3"];// will cause error


    }

    static void UserInput()
    {
        Console.Write("Enter a number: ");

        // I don't like how it is done... it seems we have look into tryparse
        int userInput = Convert.ToInt32(Console.ReadLine());


        Console.Write("\n");
        Console.WriteLine($"You entered {userInput}");
    }

    static void TypeCasting()
    {
        // char -> int -> long -> float -> double
        int intNum = 2;
        long longNum = intNum;
        float floatNum = longNum;
        double doubleNum = longNum;

        Console.WriteLine($"{intNum} is of type {intNum.GetType()}");
        Console.WriteLine($"{longNum} is of type {longNum.GetType()}");
        Console.WriteLine($"{floatNum} is of type {floatNum.GetType()}");
        Console.WriteLine($"{doubleNum} is of type {doubleNum.GetType()}");

        floatNum = (float)longNum;
        Console.WriteLine($"{floatNum} is of type {floatNum.GetType()}");

        intNum = (int)Convert.ToUInt64(floatNum);
        // etc
    }
}
